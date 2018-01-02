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
    }
}
