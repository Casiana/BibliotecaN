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
    public partial class MembruForm : Form
    {
        public int id;
        public MembruForm()
        {
            InitializeComponent();
        }

        private void MembruForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var memberInfo = new MemberInformation(this);
            memberInfo.id = this.id;
            memberInfo.ShowDialog();
            //this.Close();

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Form1();
            newForm.Show();
            this.Close();

        }
    }
}
