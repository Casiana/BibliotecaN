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
    public partial class MemberSettings : Form
    {
        public MembruForm root;
        
        public MemberSettings(MembruForm Root)
        {
            root = Root;
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSchimba_Click(object sender, EventArgs e)
        {
            try
            {

                using (var db = new BibliotecaEntities())
                {
                    var user = (from p in db.People
                                where p.ID == root.id
                                select p).First();
                    if (user.Parola == PasswordHash.GetHashString(textBoxCurrentPassword.Text))
                    {
                        if (textBoxNewPassword.Text == textBoxConfirm.Text)
                        {
                            user.Parola = PasswordHash.GetHashString(textBoxNewPassword.Text);
                            db.SaveChanges();
                            MessageBox.Show("Parola schimbata cu succes!");
                            textBoxCurrentPassword.Clear();
                            textBoxNewPassword.Clear();
                            textBoxConfirm.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Parola noua nu se potriveste! Va rugam reintroduceti!");
                        }
                    }
                    else MessageBox.Show("Parola gresita! Va rugam reintroduceti!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBoxCurrentPassword.Clear();
                textBoxNewPassword.Clear();
                textBoxConfirm.Clear();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            root.Show();
            this.Close();
        }
        private void RefreshSettings()
        {
            try
            {
                using (var db = new BibliotecaEntities())
                {
                    var user = (from p in db.People
                                where p.ID == root.id
                                select p).First();
                    textBoxName.Text = user.Nume;
                    textBoxEmail.Text = user.Email;
                    textBoxPrenume.Text = user.Prenume;
                    textBoxNumar.Text = user.Telefon;
                    textBoxCnp.Text = user.CNP;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MemberSettings_Load(object sender, EventArgs e)
        {
            RefreshSettings();
        }

        private void buttonSchimba2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BibliotecaEntities())
                {
                    var user = (from p in db.People
                                where p.ID == root.id
                                select p).First();
                    if (user.Parola == PasswordHash.GetHashString(textBoxPasswd.Text))
                    {
                        
                        if (!textBoxName.Text.Equals(""))
                            user.Nume = textBoxName.Text;
                        else throw new Exception("Va rugam introduceti numele dumneavoastra!");

                        if (!textBoxPrenume.Text.Equals(""))
                            user.Prenume = textBoxPrenume.Text;
                        else throw new Exception("Va rugam introduceti prenumele dumneavoastra!");

                        if (!textBoxEmail.Text.Equals(""))
                            user.Email = textBoxEmail.Text;
                        else throw new Exception("Va rugam introduceti e-mailul!");

                      //  if (!textBoxNumar.Text.Equals(""))
                            user.Telefon = textBoxNumar.Text;
                        //else throw new Exception("Va rugam introduceti numarul de telefon!");
                        if (!textBoxName.Text.Equals(""))
                           // if (textBoxName.SelectionLength == 13)
                                user.CNP = textBoxCnp.Text;
                           // else throw new Exception("Va rugam introduceti un CNP valid");
                        else throw new Exception("Va rugam introduceti numele dumneavoastra!");

                        db.SaveChanges();
                        MessageBox.Show("Informatii actualizate!");
                        textBoxPasswd.Clear();
                        textBoxCurrentPassword.Clear();
                        textBoxNewPassword.Clear();
                        textBoxConfirm.Clear();
                    }
                    else throw new Exception("Parola incorecta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
