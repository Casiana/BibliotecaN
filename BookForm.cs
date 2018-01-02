using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaN
{
    public partial class BookForm : Form
    {
        public Image pictureImage;
        public BookForm()
        {
            InitializeComponent();
            InitializeDropDowns();
        }

        public void InitializeDropDowns()
        {
            using (var db = new BibliotecaEntities())
            {
                List<string> authors = new List<string>();
                List<string> domains = new List<string>();
                List<string> publishers = new List<string>();
                var query = from a in db.Authors
                            select a;
                foreach (var item in query)
                {
                    authors.Add(item.Nume);
                }

                var query2 = from d in db.Domains
                             select d;
                foreach (var item in query2)
                {
                    domains.Add(item.Nume);
                }
                var query3 = from p in db.Publishers
                             select p;
                foreach (var item in query3)
                {
                    publishers.Add(item.Nume);
                }

                publisher_combo.DataSource = publishers;
                autor_combo.DataSource = authors;
                domain_combo.DataSource = domains;

            }
        }

        public string ImageToBase64(Image image,
            System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            
        }
    }
}
