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

namespace BibliotecaN
{
    public partial class MemberTransferuri : Form
    {
        MembruForm root;
        public MemberTransferuri(MembruForm rooT)
        {
            root = rooT;
            InitializeComponent();
        }
        public void UpdateListView()
        {

            string[] arr = new string[6];

            ListViewItem itm;
            // arr[1] = "2";
            try
            {
                using (var db = new BibliotecaEntities())
                {
                    //using(var trans=db.Database.begin)

                    var transfer = db.Schimbs.Where(x => x.ID_Solicitant == root.id);

                    foreach (var idTransfer in transfer)
                    {
                        var carte = db.Books.First(x => x.ID == idTransfer.ID_CARTE);

                        string titlu = carte.Titlu.ToString();
                        arr[0] = titlu;

                        string autor = db.Authors.First(x => x.ID == carte.Autor).Nume.ToString();
                        arr[1] = autor;

                        string iSBN = carte.ISBN.ToString();
                        arr[2] = iSBN;

                        var destinatar = db.People.First(x => x.ID == idTransfer.ID_Destinatar);
                        string nume = destinatar.Nume.ToString() + " " + destinatar.Prenume.ToString();
                        string username = destinatar.Utilizator.ToString();
                        arr[3] = nume;
                        arr[4] = username;
                        Color culoare;
                        string stare;
                        switch (idTransfer.Accept_destinatar)
                        {
                            case 0:
                                stare = "Transfer in curs...";
                                culoare = System.Drawing.Color.Black;
                                break;
                            case 1:
                                stare = "Transfer acceptat!";
                                culoare = System.Drawing.Color.Green;
                                break;
                            case 2:
                                stare = "Transfer refuzat!";
                                culoare = System.Drawing.Color.Red;
                                break;
                            case 3:
                                stare = "Cererea de transfer a expirat, cartea se afla in biblioteca!";
                                culoare = System.Drawing.Color.Yellow;

                                break;
                            //itm.SubItems[5].ForeColor = System.Drawing.Color.Red;

                            default:
                                throw new Exception("A aparut o problema in baza de date va rugam anuntati administratorul!");

                        };
                        arr[5] = stare;

                        itm = new ListViewItem(arr);
                        itm.SubItems[5].ForeColor = culoare;
                        //itm.SubItems.Add(arr[5]);

                        itm.UseItemStyleForSubItems = false;
                        listView1.Items.Add(itm);

                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void MemberTransferuri_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            root.Show();
            this.Close();
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BibliotecaEntities())
                {
                    var user = db.People.FirstOrDefault(x => x.Utilizator == textBoxDestinatar.Text);
                    if (user == null)
                    {
                        MessageBox.Show("Adaugati un user valid!");
                        textBoxDestinatar.Clear();
                    }
                    else
                    {
                        var carte = db.Books.FirstOrDefault(x => x.ISBN == textBoxISBN.Text);
                        if (carte != null)
                        {

                            var imprumut = db.Lends.FirstOrDefault(x => x.Person_ID == root.id && x.Book_ID == carte.ID && x.Stare_Imprumut == 1);
                            if (imprumut != null)
                            {


                                Schimb newSchimb = new Schimb();
                                newSchimb.ID_CARTE = carte.ID;
                                newSchimb.ID_Solicitant = root.id;
                                newSchimb.ID_Destinatar = user.ID;
                                newSchimb.Accept_destinatar = 0;
                                if (db.Schimbs.Where(x => x.ID_CARTE == newSchimb.ID_CARTE && x.ID_Destinatar == newSchimb.ID_Destinatar && x.ID_Solicitant == newSchimb.ID_Solicitant && x.Accept_destinatar == 0).Any())
                                {
                                    textBoxDestinatar.Clear();
                                    textBoxISBN.Clear();
                                    throw new Exception("Transferul este deja inregistrat. Va rugam asteptati un raspuns!");
                                }
                                db.Schimbs.Add(newSchimb);
                                db.SaveChanges();
                                listView1.Items.Clear();
                                textBoxDestinatar.Clear();
                                textBoxISBN.Clear();
                                MessageBox.Show("Transferul a fost realizat cu succes!");
                                // listView1.Clear();
                                UpdateListView();
                            }
                            else
                            {
                                MessageBox.Show(String.Format("Cartea\"{0}\" nu se afla in posesia dumneavoastra ", carte.Titlu));
                            }
                        }
                        else
                        {
                            MessageBox.Show("ISBN gresit!");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
