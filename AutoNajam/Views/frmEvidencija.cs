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
            if ((textBox2.Text != "Trajanje iznajmljivanja") && (izracun_vozilo_combobox.Text != ""))
            {
                label1.Text = EvidencijaViewModel.izracunnajma(textBox2.Text, izracun_vozilo_combobox.Text) + " kn";
            }
            else
            {
                label1.Text = "Neispravan Unos";
            }
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

        

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void izracun_vozilo_combobox_MouseClick(object sender, MouseEventArgs e)
        {
            izracun_vozilo_combobox.DataSource = VoziloViewModel.ispisVozila();
            izracun_vozilo_combobox.ValueMember = "cijena";
            izracun_vozilo_combobox.DisplayMember = "naziv" ;
        }

        private void frmEvidencija_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = EvidencijaViewModel.ispisEvid();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
        }

        private void refresh_prikaz_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = EvidencijaViewModel.ispisEvid();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
        }

        private void Unos_osoba_combobox_MouseClick(object sender, MouseEventArgs e)
        {
            Unos_osoba_combobox.DataSource = OsobaViewModel.ispisOsoba();
            Unos_osoba_combobox.ValueMember = "id";
            Unos_osoba_combobox.DisplayMember = "ime";
        }
    }
}
