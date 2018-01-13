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
    public partial class CardForm : Form
    {
        public CardForm()
        {
            InitializeComponent();
        }

        private void button_cautare_Click(object sender, EventArgs e)
        {
            dataGrid_membri.Rows.Clear();
             try
            {
                using (var db = new BibliotecaEntities())
                {
                    String member_name = textBox_nume_membru.Text;
                    String[] nume = member_name.Split(' ');

                    String nume0 = nume[0];
                    String nume1 = nume[1]; 

                    int member_id = (from b in db.People
                                     where b.Nume == nume0 && b.Prenume == nume1 && b.Rol == 1
                                     select b.ID).SingleOrDefault();

                    var lended_books = db.return_card(member_id);                                    //stored procedure
                    foreach (var item in lended_books)
                    {
                        String stare;
                        if (item.Stare_Imprumut==1)
                            stare = "Nereturnata";
                        else
                            stare = "Returnata";
                        dataGrid_membri.Rows.Add(item.Titlu, item.ISBN, item.Data_Imprumut, item.Data_Retur,stare);
                    }
                 }
            }

            catch (Exception ex)
            {
                MessageBox.Show("A avut loc o eroare. Vă rugăm să încercaţi din nou.");
            } 
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BibliotecaEntities())
                {
                    if (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox_nume_membru.Text))
                    {
                        MessageBox.Show("Un camp este necompletat. Va rugam sa introduceti toate datele necesare si sa incercati din nou.");
                    }

                    else 
                    {
                        String titlu = textBox1.Text;
                        String member_name = textBox_nume_membru.Text;
                        DateTime enteredDate = DateTime.Parse(textBox2.Text);

                        int book_id = (from b in db.Books
                                         where b.Titlu==titlu
                                         select b.ID).SingleOrDefault();

                        String[] nume = member_name.Split(' ');

                        String nume0 = nume[0];
                        String nume1 = nume[1];

                        int member_id = (from b in db.People
                                         where b.Nume == nume0 && b.Prenume == nume1 && b.Rol == 1
                                         select b.ID).SingleOrDefault();

                        var rowToUpdate = db.Lends.Where(o => (o.Book_ID == book_id)).Where(o => (o.Person_ID == member_id)).Where(o => o.Stare_Imprumut==1);
                        if (rowToUpdate.Any())
                        {
                            foreach (var item in rowToUpdate)
                            { 
                                item.Data_Retur = enteredDate;
                            }
                            MessageBox.Show("Data de returnare a fost schimbata.");
                        }
                        else
                            MessageBox.Show("Cartea nu se afla la membrul selectat.");
                        db.SaveChanges();                           
                    }
                }
        }

            catch (Exception ex)
            {
                MessageBox.Show("A avut loc o eroare. Vă rugăm să încercaţi din nou.");
            }
}

    }
}

