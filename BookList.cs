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
    public partial class BookList : Form
    {

        public MembruForm root;
        public BookList(MembruForm rooT)
        {
            root = rooT;
            InitializeComponent();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            
            using (var db = new BibliotecaEntities())
            {
                try
                {
                    BindingSource bi = new BindingSource();
                    bi.DataSource = db.booksViews.ToList();
                    dataGridView1.DataSource = bi;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Refresh();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            root.Show();
            this.Close();
        }
    }
}
