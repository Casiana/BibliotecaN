using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Transactions;

namespace BibliotecaN
{
    public partial class MemberRequestChange : Form
    {
        public MembruForm root;
        public MemberRequestChange(MembruForm rooT)
        {
            root = rooT;
            InitializeComponent();
        }

        private void MemberRequestChange_Load(object sender, EventArgs e)
        {

            UpdateListView();

        }
        public void UpdateListView()
        {
           
            string[] arr = new string[5];

            ListViewItem itm;
            // arr[1] = "2";
            using (var db = new BibliotecaEntities())
            {
                // using(var trans=db.)

                var transfer = db.Schimbs.Where(x => x.ID_Destinatar == root.id && x.Accept_destinatar == 0);

                foreach (var idTransfer in transfer)
                {
                    var carte = db.Books.First(x => x.ID == idTransfer.ID_CARTE);

                    string titlu = carte.Titlu.ToString();
                    arr[0] = titlu;

                    string autor = db.Authors.First(x => x.ID == carte.Autor).Nume.ToString();
                    arr[1] = autor;

                    string iSBN = carte.ISBN.ToString();
                    arr[2] = iSBN;

                    var solicitant = db.People.First(x => x.ID == idTransfer.ID_Solicitant);
                    string nume = solicitant.Nume.ToString() + " " + solicitant.Prenume.ToString();
                    string username = solicitant.Utilizator.ToString();
                    arr[3] = nume;
                    arr[4] = username;




                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);
                    
                }




            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            root.Show();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //  MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
            var trans = new ConfirmareTransfer(this);
            trans.ShowDialog();

        }
    }

}
