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
<<<<<<< HEAD
           // this.Close();
            var createAcc = new CreateAccount(); 
            createAcc.Show();
=======
            using (var db = new BibliotecaEntities())
            {
                this.Hide();
                var createAcc = new CreateAccount();
                createAcc.ShowDialog();
                this.Close();
            }
>>>>>>> a67c77aaf975614773554114d907f6855b8480e3
        }

        private void button1_Click(object sender, EventArgs e)      //autentificare
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

                if (login)
                {
                    if (rol == 1)
                    {
                        this.Hide();
                        var membru = new MembruForm();
                        membru.id = (from p in db.People
                                     where p.Utilizator == username.Text
                                     select p.ID).First();
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
        }
        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
