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
    public partial class FormImprumutate : Form
    {
        public MembruForm root;
        public FormImprumutate(MembruForm rooT)
        {
            root = rooT;
            InitializeComponent();
            comboBoxBorrow.SelectedIndex = 4;
        }

        private void FormImprumutate_Load(object sender, EventArgs e)
        {
            string s = comboBoxBorrow.Text;
            using (var db = new BibliotecaEntities())
            {
                try
                {
                    BindingSource bi = new BindingSource();
                    if (s.Equals("Data_retur"))
                    {
                        bi.DataSource = db.afiseaza_carti_imprumutate(root.id);
                        dataGridViewImprumutate.DataSource = bi;
                        dataGridViewImprumutate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewImprumutate.Refresh();
                    }
                    if (s.Equals("Titlu"))
                    {
                        bi.DataSource = db.afiseaza_carti_imprumutate_titlu(root.id);
                        dataGridViewImprumutate.DataSource = bi;
                        dataGridViewImprumutate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewImprumutate.Refresh();
                    }
                    if (s.Equals("Autor"))
                    {
                        bi.DataSource = db.afiseaza_carti_imprumutate_autor(root.id);
                        dataGridViewImprumutate.DataSource = bi;
                        dataGridViewImprumutate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewImprumutate.Refresh();
                    }
                    if (s.Equals("Domeniu"))
                    {
                        bi.DataSource = db.afiseaza_carti_imprumutate_domeniu(root.id);
                        dataGridViewImprumutate.DataSource = bi;
                        dataGridViewImprumutate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewImprumutate.Refresh();
                    }
                    if (s.Equals("Editura"))
                    {
                        bi.DataSource = db.afiseaza_carti_imprumutate_editura(root.id);
                        dataGridViewImprumutate.DataSource = bi;
                        dataGridViewImprumutate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewImprumutate.Refresh();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            root.Show();
            this.Close();
        }

        private void dataGridViewImprumutate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxBorrow_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Refresh();
            this.FormImprumutate_Load(sender, e);
        }
    }
}
