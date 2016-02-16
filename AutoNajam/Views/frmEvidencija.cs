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
    public partial class frmEvidencija : Form
    {
        public frmEvidencija()
        {
            InitializeComponent();
        }


        private void izracun_Click(object sender, EventArgs e)
        {
            
            izracunnajma_button.Text = Convert.ToString(Convert.ToInt32(comboBox3.Text) * Convert.ToInt32(textBox2.Text));
        }

        private void osobe_button_Click(object sender, EventArgs e)
        {
            frmOsobe osobe = new frmOsobe();
            osobe.Show();
        }

        private void vozila_button_Click(object sender, EventArgs e)
        {
            frmVozila vozila = new frmVozila();
            vozila.Show();
        }

        private void comboBox3_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox3.DataSource = VoziloViewModel.ispisVozila();
            comboBox3.ValueMember = "cijena";
            comboBox3.DisplayMember = "naziv";
        }
    }
}
