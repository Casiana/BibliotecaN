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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)     //creare cont utilizator
        {
            var createAcc = new CreateAccount(); 
            createAcc.Show();
        }

        private void button1_Click(object sender, EventArgs e)      //autentificare
        {
            try
            {
                bool login = false;
                int rol = 0;
                using (var db = new BibliotecaEntities())
                {
                    var query = from p in db.People
                                select p;
                    foreach (var item in query)
                    {
                        if (item.Utilizator == username.Text)
                        {
                            if (item.Parola == PasswordHash.GetHashString(password.Text))
                            {
                                rol = item.Rol;
                                login = true;
                            }
                        }
                    }
                }
                if (login)
                {
                    if (rol == 1)
                    {
                        this.Hide();
                        var membru = new MembruForm();
                        membru.ShowDialog();
                        this.Close();
                    }
                    if (rol == 2)
                    {
                        this.Hide();
                        var administrator = new AdministratorForm();
                        administrator.ShowDialog();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Parola sau Nume de utilizator Incorect");
            }
            catch (Exception ex)
            {
                MessageBox.Show("A avut loc o eroare. Vă rugăm să încercaţi din nou.");
            }
        }

      
    }
}
