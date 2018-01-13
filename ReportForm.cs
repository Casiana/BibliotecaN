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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Biblioteca2DataSet2.raport_view1' table. You can move, or remove it, as needed.
            this.raport_view1TableAdapter.Fill(this.Biblioteca2DataSet2.raport_view1);

            this.reportViewer1.RefreshReport();
        }
    }
}
