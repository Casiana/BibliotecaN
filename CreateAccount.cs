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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BibliotecaEntities())
                {

                    if (String.IsNullOrEmpty(username.Text) || 
                        String.IsNullOrEmpty(password.Text) || 
                        String.IsNullOrEmpty(cnp.Text) ||
                        String.IsNullOrEmpty(name.Text) || 
                        String.IsNullOrEmpty(last_name.Text) )
                    {
                        MessageBox.Show("Va rugam completati campurile marcate cu (*).");
                    }

                    else 
                    {
                        String checked_username = (from b in db.People
                                    where b.Utilizator == username.Text
                                    select b.Utilizator).FirstOrDefault();

                        if (String.IsNullOrEmpty(checked_username)==false)
                            MessageBox.Show("Username existent in baza de date. Va rugam incercati din nou.");

                        else
                        {
                            var user = new Person();
                            user.Utilizator = username.Text;
                            user.Parola = PasswordHash.GetHashString(password.Text); // aici pentru securitate
                            user.Nume = name.Text;
                            user.Prenume = last_name.Text;
                            user.CNP = cnp.Text;
                            user.Telefon = phone.Text;
                            user.Email = email.Text;
                            user.Role = db.Roles.Where(r => r.ID == 1).First();
                            db.People.Add(user);
                            db.SaveChanges();

                            MessageBox.Show("Cont creat cu succes.");
                            this.Close();
                            var login = new Form1();
                            login.Show();
                        }
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
