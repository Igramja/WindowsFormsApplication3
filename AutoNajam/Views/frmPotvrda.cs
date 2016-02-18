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
using AutoNajam.Views;


namespace AutoNajam.Views
{
    public partial class frmPotvrda : Form
    {
        private int rowInd;
        public frmPotvrda(int rowIndex)
        {
            InitializeComponent();
            rowInd = rowIndex;
        }

        private void Potvrda_Load(object sender, EventArgs e)
        {
           
            var table = EvidencijaDAL.ReadEvid();
            
            DataTable table2 = table.Clone();
            table2.Rows.Add(table.Rows[rowInd].ItemArray);
            table2.TableName = "ispisEvid";





            ReportDataSource datasource = new ReportDataSource("Evidata", table2);
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            //reportViewer1.LocalReport.ReportEmbeddedResource = "AutoLib.PotvrdaReport.Potvrda.rdlc";
           // reportViewer1.LocalReport.ReportPath = "AutoLib.PotvrdaReport.Potvrda.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }


    }
}
