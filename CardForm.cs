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

        //public void InitializeNewButtons()
        //{
        //    // label3
        //    // 
        //    this.label3.AutoSize = true;
        //    this.label3.Location = new System.Drawing.Point(34, 401);
        //    this.label3.Name = "label3";
        //    this.label3.Size = new System.Drawing.Size(168, 17);
        //    this.label3.TabIndex = 5;
        //    this.label3.Text = "Modificare data returnare";
        //    // 
        //    // label4
        //    // 
        //    this.label4.AutoSize = true;
        //    this.label4.Location = new System.Drawing.Point(300, 401);
        //    this.label4.Name = "label4";
        //    this.label4.Size = new System.Drawing.Size(71, 17);
        //    this.label4.TabIndex = 6;
        //    this.label4.Text = "Titlu carte";
        //    // 
        //    // label5
        //    // 
        //    this.label5.AutoSize = true;
        //    this.label5.Location = new System.Drawing.Point(554, 401);
        //    this.label5.Name = "label5";
        //    this.label5.Size = new System.Drawing.Size(74, 17);
        //    this.label5.TabIndex = 7;
        //    this.label5.Text = "Data noua";
        //    // 
        //    // textBox1
        //    // 
        //    this.textBox1.Location = new System.Drawing.Point(303, 422);
        //    this.textBox1.Name = "textBox1";
        //    this.textBox1.Size = new System.Drawing.Size(166, 22);
        //    this.textBox1.TabIndex = 8;
        //    // 
        //    // textBox2
        //    // 
        //    this.textBox2.Location = new System.Drawing.Point(557, 422);
        //    this.textBox2.Name = "textBox2";
        //    this.textBox2.Size = new System.Drawing.Size(166, 22);
        //    this.textBox2.TabIndex = 9;
        //}

        private void button_cautare_Click(object sender, EventArgs e)
        {
            dataGrid_membri.Rows.Clear();
             try
            {
                using (var db = new BibliotecaEntities())
                {
                  //  InitializeNewButtons();

                    String member_name = textBox_nume_membru.Text;
                    String[] nume = member_name.Split(' ');

                    String nume0 = nume[0];
                    String nume1 = nume[1];

                    int member_id = (from b in db.People
                                     where b.Nume == nume0 && b.Prenume == nume1 && b.Rol == 1
                                     select b.ID).SingleOrDefault();

                    var lended_books = db.return_card(member_id);         //stored procedure
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

