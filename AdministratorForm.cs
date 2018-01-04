using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaN
{
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
            InitializeDropDowns();
        }

        public void InitializeDropDowns()
        {
            using (var db = new BibliotecaEntities())
            {
                List<string> members = new List<string>();
                List<string> books = new List<string>();
                var query = from m in db.People
                            where m.Rol == 1 select m;
                foreach (var item in query)
                {
                    members.Add(item.Nume + " " + item.Prenume);
                }

                var query2 = from b in db.Books
                             select b;
                foreach (var item in query2)
                {
                    books.Add(item.Titlu);
                }
                
                membru_combo.DataSource = members;
                carte_combo.DataSource = books;

            }
        }

        private void add_domain_Click(object sender, EventArgs e)
        {
            using (var db = new BibliotecaEntities())
            {
                var domain = new Domain();
                domain.Nume = domain_text.Text;
                db.Domains.Add(domain);
                db.SaveChanges();
                domain_text.Text = "";
                MessageBox.Show("Domeniu creat cu success!");
            }
        }

        private void add_author_Click(object sender, EventArgs e)
        {
            using (var db = new BibliotecaEntities())
            {
                var autor = new Author();
                autor.Nume = author_text.Text;
                db.Authors.Add(autor);
                db.SaveChanges();
                author_text.Text = "";
                MessageBox.Show("Autor creat cu success!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new BibliotecaEntities())
            {
                var publisher = new Publisher();
                publisher.Nume = publisher_text.Text;
                db.Publishers.Add(publisher);
                db.SaveChanges();
                publisher_text.Text = "";
                MessageBox.Show("Editura creata cu success!");
            }
        }

        private void add_book_Click(object sender, EventArgs e)
        {
            var book_form = new BookForm();
            book_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new BibliotecaEntities())
            {
                var imprumut = new Lend();
                var titlu = carte_combo.SelectedItem.ToString();
                var nume = membru_combo.SelectedItem.ToString().Split().FirstOrDefault();
                var result = (from b in db.Books
                              where b.Titlu == titlu
                              select b).SingleOrDefault();
                if (result.Exemplare == 0)
                {
                    MessageBox.Show("Nu mai sunt carti disponibile ");
                    return;
                }
                result.Exemplare = result.Exemplare - 1;
                imprumut.Book = result;
                var result2 = (from d in db.People
                               where d.Nume == nume
                               select d).SingleOrDefault();
                imprumut.Person = result2;
                imprumut.Data_Imprumut = DateTime.Now;
                imprumut.Data_Retur = DateTime.Now.AddDays(30);
                db.Lends.Add(imprumut);
                db.SaveChanges();

                MessageBox.Show("Imprumut adaugat cu success!");
            }
        }
    }
}
