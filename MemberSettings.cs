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
        public int id;
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
                                where p.ID == id
                                select p).First();
                    if (user.Parola == PasswordHash.GetHashString(textBoxCurrentPassword.Text))
                    {
                        if(textBoxNewPassword.Text==textBoxConfirm.Text)
                        {
                            user.Parola = PasswordHash.GetHashString(textBoxNewPassword.Text);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Parola incorecta! Va rugam reintroduceti!");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            root.Show();
            this.Close();
        }
    }
}
