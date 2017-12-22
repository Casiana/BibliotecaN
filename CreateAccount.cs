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
                    var user = new Person();
                    user.Utilizator = username.Text;
                    user.Parola = PasswordHash.GetHashString(password.Text); // aici pentru securitate
                    user.Nume = name.Text;
                    user.Prenume = last_name.Text;
                    user.CNP = cnp.Text;
                    user.Telefon = phone.Text;
                    user.Email = email.Text;
                    user.Rol = 1;
                    user.Role = db.Roles.Where(r => r.ID == 1).First();
                    db.People.Add(user);
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
            var login = new Form1();
            login.Show();

        }
    }
}
