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
        ListSortDirection direction;
        public MembruForm root;
        public BookList(MembruForm rooT)
        {
            root = rooT;
            InitializeComponent();
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            updateDatagrid();
           
            comboBoxOrdonare.SelectedIndex = 0;
        }

        void updateDatagrid()
        {
            using (var db = new BibliotecaEntities())
            {

                try
                {
                    BindingSource bi = new BindingSource();
                    var source = db.booksViews.ToList();

                    bi.DataSource = source;
                    dataGridView1.DataSource = bi;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Refresh();
                    dataGridView1.Columns["ID"].Visible = false;
                }
                catch (Exception ex)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void labelFiltru_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxOrdonare_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show(comboBoxOrdonare.Text);
                switch (comboBoxOrdonare.Text)
                {
                    case "Titlu":

                        dataGridView1.Sort(dataGridView1.Columns["Titlu"], ListSortDirection.Descending);


                        break;
                    case "Autor":

                        dataGridView1.Sort(dataGridView1.Columns["Autor"], direction);
                        break;

                    case "Domeniu":

                        dataGridView1.Sort(dataGridView1.Columns["Domeniu"], ListSortDirection.Ascending);

                        break;

                    default:
                        break;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
