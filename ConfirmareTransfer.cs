using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace BibliotecaN
{
    public partial class ConfirmareTransfer : Form
    {
        MemberRequestChange root;
        public ConfirmareTransfer(MemberRequestChange rooT)
        {
            root = rooT;
            InitializeComponent();
        }

        private void buttonNu_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BibliotecaEntities())
                {
                    var carteNume = root.listView1.SelectedItems[0].SubItems[0].Text;
                    var carte = db.Books.First(x => x.Titlu == carteNume);

                    var inreg = db.Schimbs.First(x => x.ID_Destinatar == root.root.id && x.ID_CARTE == carte.ID && x.Accept_destinatar == 0);
                    //MessageBox.Show(inreg.Accept_destinatar.ToString());

                    inreg.Accept_destinatar = 2;

                    db.SaveChanges();
                    root.listView1.Items.Clear();
                    root.UpdateListView();

                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDa_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BibliotecaEntities())
                {
                    var carteNume = root.listView1.SelectedItems[0].SubItems[0].Text;
                    var carte = db.Books.First(x => x.Titlu == carteNume);

                    var inreg = db.Schimbs.First(x => x.ID_Destinatar == root.root.id && x.ID_CARTE == carte.ID && x.Accept_destinatar == 0);
                    //MessageBox.Show(inreg.Accept_destinatar.ToString());

                    inreg.Accept_destinatar = 1;


                    var imprumut = db.Lends.First(x => x.Person_ID == inreg.ID_Solicitant && x.Book_ID == inreg.ID_CARTE);
                   // MessageBox.Show(imprumut.Data_Retur.ToString());
                    imprumut.Person_ID = inreg.ID_Destinatar;

                    db.SaveChanges();
                    root.listView1.Items.Clear();
                    root.UpdateListView();

                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
