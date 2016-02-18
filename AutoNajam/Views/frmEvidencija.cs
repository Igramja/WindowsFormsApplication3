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
        DateTime vrijemeiznajmljivanja;
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
        private void Unos_osoba_combobox_MouseClick(object sender, MouseEventArgs e)
        {
            Unos_osoba_combobox.DataSource = OsobaViewModel.ispisOsoba();
            Unos_osoba_combobox.ValueMember = "id";
            Unos_osoba_combobox.DisplayMember = "oib";
        }

        private void Unos_vozilo_combobox_MouseClick(object sender, MouseEventArgs e)
        {
            Unos_vozilo_combobox.DataSource = VoziloViewModel.ispisVozila();
            Unos_vozilo_combobox.ValueMember = "id";
            Unos_vozilo_combobox.DisplayMember = "naziv";
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

        private void unos_najam_button_Click(object sender, EventArgs e)
        {
            if ((Unos_osoba_combobox.Text != "") && (Unos_vozilo_combobox.Text != ""))
            {
                var novi = new EvidencijaViewModel();
                novi.unosIzn(Convert.ToInt32(Unos_osoba_combobox.SelectedValue), Convert.ToInt32(Unos_vozilo_combobox.SelectedValue), datumizn_dateTimePicker.Value);
                unos_novi_label.Text = "";
            }
            else
            {
                unos_novi_label.Text = "Unos Neispravan!";
            }
        }

        public void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {   

            
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                vrijemeiznajmljivanja = Convert.ToDateTime(selectedRow.Cells["vrijemeizn"].Value);

                naziv_vozila_textbox.Text = Convert.ToString(selectedRow.Cells["naziv"].Value);

                broj_najma_textbox.Text = Convert.ToString(selectedRow.Cells["id"].Value); 
            }
            else

                broj_najma_textbox.Text = "#";
        }

        public void unos_krajnajma_button_Click(object sender, EventArgs e)
        {
            if (vrijemeiznajmljivanja < dateTimePicker1.Value)
            {
                decimal autocijena = VoziloViewModel.cijenaauta(naziv_vozila_textbox.Text);
                var novivr = new EvidencijaViewModel();
                novivr.unosVr(broj_najma_textbox.Text, dateTimePicker1.Value, cijenaizn(vrijemeiznajmljivanja, dateTimePicker1.Value, autocijena));
                unos_vr_label.Text ="";
            }
            else
            {
                unos_vr_label.Text = "Unos neispravan!";
            }
        }

        public decimal cijenaizn(DateTime vrijemeizn, DateTime vrijemevra, decimal cijena)
        {
            TimeSpan sati = vrijemevra.Subtract(vrijemeizn);
            return Convert.ToInt32(sati.TotalHours) * cijena;
        }

        private void kraj_najma_group_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
            frmPotvrda potvrda = new frmPotvrda(rowIndex);
            potvrda.Show();
        }
    }
}
