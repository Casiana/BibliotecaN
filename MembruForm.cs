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
            memberInfo.ShowDialog();
            

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Form1();
            newForm.ShowDialog();
            this.Close();

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            var memberSettings = new MemberSettings(this);
            memberSettings.ShowDialog();
            //this.close();

        }

        private void buttonBookList_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            var searchBook = new FormBookSearch(this);
            searchBook.ShowDialog();
        }

        private void buttonSolicitaSchimb_Click(object sender, EventArgs e)
        {
            this.Hide();
            var req = new MemberRequestChange(this);
            req.ShowDialog();
            
        }

        private void buttonBookRequest_Click(object sender, EventArgs e)
        {
            this.Hide();
            var confirmareTransfer = new MemberTransferuri(this);
            confirmareTransfer.ShowDialog();
            //this.Close();

        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            this.Hide();
            var borrowBooks = new FormImprumutate(this);
            borrowBooks.ShowDialog();
        }
    }
}
