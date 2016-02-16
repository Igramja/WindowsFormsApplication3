using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1.ViewModel;

namespace AutoNajam.Views
{
    public partial class frmVozila : Form
    {
        public frmVozila()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (maskedTextBox1.Text != "  ." ) && (textBox3.Text != ""))
            {
                var unos = new VoziloViewModel();
                unos.unesiVozilo(textBox1.Text, Convert.ToDecimal(maskedTextBox1.Text), textBox3.Text);
                label4.Text = "";
            }
            else
            {
                label4.Text = "Neispravan Unos";
            }

        }
        private void frmVozila_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = VoziloViewModel.ispisVozila();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = VoziloViewModel.ispisVozila();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
        }
    }
}
