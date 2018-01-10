using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaN
{
    public partial class BookForm : Form
    {
        public Image pictureImage;
        public BookForm()
        {
            InitializeComponent();
            InitializeDropDowns();
        }

        public void InitializeDropDowns()
        {
            using (var db = new BibliotecaEntities())
            {
                List<string> authors = new List<string>();
                List<string> domains = new List<string>();
                List<string> publishers = new List<string>();
                var query = from a in db.Authors
                            select a;
                foreach (var item in query)
                {
                    authors.Add(item.Nume);
                }

                var query2 = from d in db.Domains
                             select d;
                foreach (var item in query2)
                {
                    domains.Add(item.Nume);
                }
                var query3 = from p in db.Publishers
                             select p;
                foreach (var item in query3)
                {
                    publishers.Add(item.Nume);
                }

                publisher_combo.DataSource = publishers;
                autor_combo.DataSource = authors;
                domain_combo.DataSource = domains;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            using (var db = new BibliotecaEntities())
            { 
                var book = new Book();
                book.Titlu = titluBox.Text;
                book.ISBN = isbnBox.Text;
                book.Exemplare = Int32.Parse(exemBox.Text);
                book.Descriere = descriereBox.Text;
                var domeniu_text = domain_combo.SelectedItem.ToString();
                var autor_text = autor_combo.SelectedItem.ToString();
                var editura_text = publisher_combo.SelectedItem.ToString();
                var domeniu = (from d in db.Domains
                               where d.Nume == domeniu_text
                               select d).FirstOrDefault();
                book.Domain = domeniu;

                var autor = (from a in db.Authors
                             where a.Nume == autor_text
                             select a).FirstOrDefault();
                book.Author = autor;

                var editura = (from p in db.Publishers
                               where p.Nume == editura_text
                               select p).FirstOrDefault();
                book.Publisher = editura;

                db.Books.Add(book);
                db.SaveChanges();
                this.Close();
                MessageBox.Show("Carte creata cu success!");
            }
        }
    }
}
