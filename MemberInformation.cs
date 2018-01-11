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
    public partial class MemberInformation : Form
    {
       
        public MembruForm root;
        public MemberInformation(MembruForm rooT)
        {
            root = rooT;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

  

        private void MemberInformation_Load(object sender, EventArgs e)
        {
            using (var db = new BibliotecaEntities())
            {
                var user = (from p in db.People
                            where p.ID == root.id
                            select p).First();
                labelUsername.Text = user.Utilizator.ToString();
                labelName.Text = user.Nume.ToString() + " " + user.Prenume.ToString();
                labelCNP.Text = user.CNP.ToString();
                labelContactNo.Text = user.Telefon.ToString();
                labelEmail.Text = user.Email.ToString();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
               
                root.Show();
                this.Close();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void labelCNP_Click(object sender, EventArgs e)
        {

        }

        private void labelContactNo_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
