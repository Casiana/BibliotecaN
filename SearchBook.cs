using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Web;
using Microsoft.Reporting.WinForms;

namespace BibliotecaN
{
    public partial class FormBookSearch : Form
    {

        public MembruForm root;
       // DataTable dt;

        public FormBookSearch(MembruForm rooT)
        {
            root = rooT;
            InitializeComponent();
        }
        private void FormBookSearch_Load(object sender, EventArgs e)
        {
            //  BindingSource bs = (BindingSource)dataGridViewSearch.DataSource;//You should first convert DataSourse into Binding Sourse
            // DataTable dt = (DataTable)bs.DataSource; //Get GridView data source to Data table

            //var bs = (BindingSource)dataGridViewSearch.DataSource;
            // dt = (DataTable)bs.DataSource;

            string s = comboBoxSearch.Text;
            comboBoxSearch.SelectedIndex = 0;
            using (var db = new BibliotecaEntities())
            {
                try
                {
                    BindingSource bi = new BindingSource();
                    {
                        bi.DataSource = db.cauta_dupa_titlu("");
                        dataGridViewSearch.DataSource = bi;
                        dataGridViewSearch.Columns["Titlu"].DisplayIndex = 0;
                        dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewSearch.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string s = comboBoxSearch.Text;
            using (var db = new BibliotecaEntities())
            {
                try
                {
                    BindingSource bi = new BindingSource();
                    if (s.Equals("Autor"))
                    {
                        bi.DataSource = db.cauta_dupa_autor(textBoxSearch.Text);
                        dataGridViewSearch.DataSource = bi;
                        dataGridViewSearch.Columns["Autor"].DisplayIndex = 0;
                        dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewSearch.Refresh();
                    }
                    if (s.Equals("Nume Carte"))
                    {
                        bi.DataSource = db.cauta_dupa_titlu(textBoxSearch.Text);
                        dataGridViewSearch.DataSource = bi;
                        dataGridViewSearch.Columns["Titlu"].DisplayIndex = 0;
                        dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewSearch.Refresh();
                    }
                    if (s.Equals("Domeniu"))
                    {
                        bi.DataSource = db.cauta_dupa_domeniu(textBoxSearch.Text);
                        dataGridViewSearch.DataSource = bi;
                        dataGridViewSearch.Columns["Domeniu"].DisplayIndex = 0;
                        dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewSearch.Refresh();
                    }
                    if (s.Equals("Editura"))
                    {
                        bi.DataSource = db.cauta_dupa_editura(textBoxSearch.Text);
                        dataGridViewSearch.DataSource = bi;
                        dataGridViewSearch.Columns["Editura"].DisplayIndex = 0;
                        dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewSearch.Refresh();
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
            this.Close();
            root.Show();
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch_Click(sender, e);            }
        }
    

        private void ExportToExcel(string path)
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            try
            {
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "ExportedFromDatGrid";

                for (int i = 1; i < dataGridViewSearch.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridViewSearch.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridViewSearch.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewSearch.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridViewSearch.Rows[i].Cells[j].Value.ToString();
                    }
                }
               

             //   if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             //   {
                    workbook.SaveAs(path);
           //         MessageBox.Show("Export Successful");
           //     }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }

        private void ExportToPdf(string path)
        {


               PdfPTable pdfTable = new PdfPTable(dataGridViewSearch.ColumnCount);
               pdfTable.DefaultCell.Padding = 3;
               pdfTable.WidthPercentage = 30;
               pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
               pdfTable.DefaultCell.BorderWidth = 1;

               foreach (DataGridViewColumn column in dataGridViewSearch.Columns)
               {
                   PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                   cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                   pdfTable.AddCell(cell);
               }

               //Adding DataRow
               foreach (DataGridViewRow row in dataGridViewSearch.Rows)
               {
                   foreach (DataGridViewCell cell in row.Cells)
                   {
                       pdfTable.AddCell(cell.Value.ToString());
                   }
               }
               string folderPath = path;
               //if (!Directory.Exists(folderPath))
               //{
               //    Directory.CreateDirectory(folderPath);
               //}
               using (FileStream stream = new FileStream(folderPath, FileMode.Create))
               {
                   Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                   PdfWriter.GetInstance(pdfDoc, stream);
                   pdfDoc.Open();
                   pdfDoc.Add(pdfTable);
                   pdfDoc.Close();
                   stream.Close();
               }
        }

        private void exportToCSV(string path)
        {
            try
            {
                System.IO.StreamWriter csvFileWriter = new StreamWriter(path, false);

                string columnHeaderText = "";

                int countColumn = dataGridViewSearch.ColumnCount - 1;

                if (countColumn >= 0)
                {
                    columnHeaderText = dataGridViewSearch.Columns[0].HeaderText;
                }

                for (int i = 1; i <= countColumn; i++)
                {
                    columnHeaderText = columnHeaderText + ',' + dataGridViewSearch.Columns[i].HeaderText;
                }


                csvFileWriter.WriteLine(columnHeaderText);

                foreach (DataGridViewRow dataRowObject in dataGridViewSearch.Rows)
                {
                    if (!dataRowObject.IsNewRow)
                    {
                        string dataFromGrid = "";

                        dataFromGrid = dataRowObject.Cells[0].Value.ToString();

                        for (int i = 1; i <= countColumn; i++)
                        {
                            dataFromGrid = dataFromGrid + ',' + dataRowObject.Cells[i].Value.ToString();

                            csvFileWriter.WriteLine(dataFromGrid);
                        }
                    }
                }


                csvFileWriter.Flush();
                csvFileWriter.Close();
            }
            catch (Exception exceptionObject)
            {
                MessageBox.Show(exceptionObject.ToString());
            }
        }
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
           
          
            
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|Pdf files (*.pdf)|*.pdf|CSV files(*.csv)|*.csv";
            DialogResult r = saveDialog.ShowDialog();
            if (r == DialogResult.OK)
            {
                switch (saveDialog.FilterIndex)
                {
                    case 1:
                        ExportToExcel(saveDialog.FileName);
                        MessageBox.Show("Export Successful");
                        break;
                    case 2:
                        ExportToPdf(saveDialog.FileName);
                        MessageBox.Show("Export Successful");
                        break;
                    case 3:
                        exportToCSV(saveDialog.FileName);
                        MessageBox.Show("Export Successful");
                        break;
                    

                }
            }           
            reportViewer1.Show();
        }
   

        private void dataGridViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
