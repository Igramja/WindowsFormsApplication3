using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1.DAL;
using ClassLibrary1.PotvrdaReport;
using Microsoft.Reporting.WinForms;


namespace AutoNajam.Views
{
    public partial class frmPotvrda : Form
    {
        public frmPotvrda()
        {
            InitializeComponent();
        }

        private void Potvrda_Load(object sender, EventArgs e)
        {
            var table = EvidencijaDAL.ReadEvid();
            table.TableName = "ispisEvid";
            var dataset = new DataSet("EVIDataset");
            dataset.Tables.Add(table);

            ReportDataSource datasource = new ReportDataSource("Evidata", table);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportEmbeddedResource = "AutoLib.PotvrdaReport.Potvrda.rdlc";
            reportViewer1.LocalReport.ReportPath = "Potvrda.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);

            this.reportViewer1.RefreshReport();
        }

        
    }
}
