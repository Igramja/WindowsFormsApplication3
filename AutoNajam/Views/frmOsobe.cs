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
    public partial class frmOsobe : Form
    {
        public frmOsobe()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (oib.CheckOIB(textBox3.Text))
            {
                var unos = new OsobaViewModel();
                unos.unesiOsobu(textBox1.Text, textBox2.Text, textBox3.Text);
                label4.Text = "";
            }
            else
            {
                label4.Text = "OIB neispravan";
            }
        }

        private void frmOsobe_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = OsobaViewModel.ispisOsoba();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = OsobaViewModel.ispisOsoba();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
        }

       
    }
}
