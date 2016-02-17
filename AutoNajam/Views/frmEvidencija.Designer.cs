namespace AutoNajam.Views
{
    partial class frmEvidencija
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Unos_osoba_combobox = new System.Windows.Forms.ComboBox();
            this.Unos_vozilo_combobox = new System.Windows.Forms.ComboBox();
            this.unos_najam_button = new System.Windows.Forms.Button();
            this.refresh_prikaz = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.osobe_button = new System.Windows.Forms.Button();
            this.vozila_button = new System.Windows.Forms.Button();
            this.izracunnajma_button = new System.Windows.Forms.Button();
            this.datumizn_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.izracun_vozilo_combobox = new System.Windows.Forms.ComboBox();
            this.izracuncijene_group = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unos_vozilaiosoba_group = new System.Windows.Forms.GroupBox();
            this.unos_najma_group = new System.Windows.Forms.GroupBox();
            this.kraj_najma_group = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.unos_krajnajma_button = new System.Windows.Forms.Button();
            this.broj_najma_textbox = new System.Windows.Forms.TextBox();
            this.naziv_vozila_textbox = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registracija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeizn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemevr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unos_vr_label = new System.Windows.Forms.Label();
            this.unos_novi_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.izracuncijene_group.SuspendLayout();
            this.unos_vozilaiosoba_group.SuspendLayout();
            this.unos_najma_group.SuspendLayout();
            this.kraj_najma_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // Unos_osoba_combobox
            // 
            this.Unos_osoba_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Unos_osoba_combobox.FormattingEnabled = true;
            this.Unos_osoba_combobox.Location = new System.Drawing.Point(10, 21);
            this.Unos_osoba_combobox.Name = "Unos_osoba_combobox";
            this.Unos_osoba_combobox.Size = new System.Drawing.Size(121, 21);
            this.Unos_osoba_combobox.TabIndex = 0;
            this.Unos_osoba_combobox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Unos_osoba_combobox_MouseClick);
            // 
            // Unos_vozilo_combobox
            // 
            this.Unos_vozilo_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Unos_vozilo_combobox.FormattingEnabled = true;
            this.Unos_vozilo_combobox.Location = new System.Drawing.Point(145, 21);
            this.Unos_vozilo_combobox.Name = "Unos_vozilo_combobox";
            this.Unos_vozilo_combobox.Size = new System.Drawing.Size(121, 21);
            this.Unos_vozilo_combobox.TabIndex = 1;
            this.Unos_vozilo_combobox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Unos_vozilo_combobox_MouseClick);
            // 
            // unos_najam_button
            // 
            this.unos_najam_button.Location = new System.Drawing.Point(10, 97);
            this.unos_najam_button.Name = "unos_najam_button";
            this.unos_najam_button.Size = new System.Drawing.Size(75, 23);
            this.unos_najam_button.TabIndex = 4;
            this.unos_najam_button.Text = "Unos";
            this.unos_najam_button.UseVisualStyleBackColor = true;
            this.unos_najam_button.Click += new System.EventHandler(this.unos_najam_button_Click);
            // 
            // refresh_prikaz
            // 
            this.refresh_prikaz.Location = new System.Drawing.Point(209, 145);
            this.refresh_prikaz.Name = "refresh_prikaz";
            this.refresh_prikaz.Size = new System.Drawing.Size(75, 23);
            this.refresh_prikaz.TabIndex = 5;
            this.refresh_prikaz.Text = "Osvježi ispis";
            this.refresh_prikaz.UseVisualStyleBackColor = true;
            this.refresh_prikaz.Click += new System.EventHandler(this.refresh_prikaz_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 283);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ime,
            this.prezime,
            this.oib,
            this.naziv,
            this.registracija,
            this.vrijemeizn,
            this.vrijemevr,
            this.cijena});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(787, 283);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // osobe_button
            // 
            this.osobe_button.Location = new System.Drawing.Point(27, 38);
            this.osobe_button.Name = "osobe_button";
            this.osobe_button.Size = new System.Drawing.Size(75, 23);
            this.osobe_button.TabIndex = 7;
            this.osobe_button.Text = "Osobe";
            this.osobe_button.UseVisualStyleBackColor = true;
            this.osobe_button.Click += new System.EventHandler(this.osobe_button_Click);
            // 
            // vozila_button
            // 
            this.vozila_button.Location = new System.Drawing.Point(27, 104);
            this.vozila_button.Name = "vozila_button";
            this.vozila_button.Size = new System.Drawing.Size(75, 23);
            this.vozila_button.TabIndex = 8;
            this.vozila_button.Text = "Vozila";
            this.vozila_button.UseVisualStyleBackColor = true;
            this.vozila_button.Click += new System.EventHandler(this.vozila_button_Click);
            // 
            // izracunnajma_button
            // 
            this.izracunnajma_button.Location = new System.Drawing.Point(20, 88);
            this.izracunnajma_button.Name = "izracunnajma_button";
            this.izracunnajma_button.Size = new System.Drawing.Size(160, 23);
            this.izracunnajma_button.TabIndex = 9;
            this.izracunnajma_button.Text = "Izračunaj cijenu iznajmljivanja";
            this.izracunnajma_button.UseVisualStyleBackColor = true;
            this.izracunnajma_button.Click += new System.EventHandler(this.izracun_Click);
            // 
            // datumizn_dateTimePicker
            // 
            this.datumizn_dateTimePicker.CustomFormat = "dd.MM.yyy  H:m";
            this.datumizn_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datumizn_dateTimePicker.Location = new System.Drawing.Point(10, 62);
            this.datumizn_dateTimePicker.Name = "datumizn_dateTimePicker";
            this.datumizn_dateTimePicker.Size = new System.Drawing.Size(256, 20);
            this.datumizn_dateTimePicker.TabIndex = 10;
            this.datumizn_dateTimePicker.Value = new System.DateTime(2016, 2, 17, 12, 34, 57, 0);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Trajanje iznajmljivanja(sati)";
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // izracun_vozilo_combobox
            // 
            this.izracun_vozilo_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.izracun_vozilo_combobox.FormattingEnabled = true;
            this.izracun_vozilo_combobox.Location = new System.Drawing.Point(20, 19);
            this.izracun_vozilo_combobox.Name = "izracun_vozilo_combobox";
            this.izracun_vozilo_combobox.Size = new System.Drawing.Size(160, 21);
            this.izracun_vozilo_combobox.TabIndex = 15;
            this.izracun_vozilo_combobox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.izracun_vozilo_combobox_MouseClick);
            // 
            // izracuncijene_group
            // 
            this.izracuncijene_group.Controls.Add(this.label1);
            this.izracuncijene_group.Controls.Add(this.izracun_vozilo_combobox);
            this.izracuncijene_group.Controls.Add(this.textBox2);
            this.izracuncijene_group.Controls.Add(this.izracunnajma_button);
            this.izracuncijene_group.Location = new System.Drawing.Point(599, 12);
            this.izracuncijene_group.Name = "izracuncijene_group";
            this.izracuncijene_group.Size = new System.Drawing.Size(200, 156);
            this.izracuncijene_group.TabIndex = 16;
            this.izracuncijene_group.TabStop = false;
            this.izracuncijene_group.Text = "Izračun cijene";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 133);
            this.label1.MinimumSize = new System.Drawing.Size(180, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Cijena";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // unos_vozilaiosoba_group
            // 
            this.unos_vozilaiosoba_group.Controls.Add(this.osobe_button);
            this.unos_vozilaiosoba_group.Controls.Add(this.vozila_button);
            this.unos_vozilaiosoba_group.Location = new System.Drawing.Point(458, 12);
            this.unos_vozilaiosoba_group.Name = "unos_vozilaiosoba_group";
            this.unos_vozilaiosoba_group.Size = new System.Drawing.Size(135, 156);
            this.unos_vozilaiosoba_group.TabIndex = 17;
            this.unos_vozilaiosoba_group.TabStop = false;
            this.unos_vozilaiosoba_group.Text = "Unos vozila i osoba";
            // 
            // unos_najma_group
            // 
            this.unos_najma_group.Controls.Add(this.unos_novi_label);
            this.unos_najma_group.Controls.Add(this.Unos_osoba_combobox);
            this.unos_najma_group.Controls.Add(this.Unos_vozilo_combobox);
            this.unos_najma_group.Controls.Add(this.datumizn_dateTimePicker);
            this.unos_najma_group.Controls.Add(this.unos_najam_button);
            this.unos_najma_group.Location = new System.Drawing.Point(12, 13);
            this.unos_najma_group.Name = "unos_najma_group";
            this.unos_najma_group.Size = new System.Drawing.Size(272, 126);
            this.unos_najma_group.TabIndex = 18;
            this.unos_najma_group.TabStop = false;
            this.unos_najma_group.Text = "Unos novog najma";
            // 
            // kraj_najma_group
            // 
            this.kraj_najma_group.Controls.Add(this.unos_vr_label);
            this.kraj_najma_group.Controls.Add(this.naziv_vozila_textbox);
            this.kraj_najma_group.Controls.Add(this.dateTimePicker1);
            this.kraj_najma_group.Controls.Add(this.unos_krajnajma_button);
            this.kraj_najma_group.Controls.Add(this.broj_najma_textbox);
            this.kraj_najma_group.Location = new System.Drawing.Point(290, 13);
            this.kraj_najma_group.Name = "kraj_najma_group";
            this.kraj_najma_group.Size = new System.Drawing.Size(162, 126);
            this.kraj_najma_group.TabIndex = 19;
            this.kraj_najma_group.TabStop = false;
            this.kraj_najma_group.Text = "Vozilo vraćeno";
            this.kraj_najma_group.Enter += new System.EventHandler(this.kraj_najma_group_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyy  H:m";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2016, 2, 17, 12, 39, 0, 0);
            // 
            // unos_krajnajma_button
            // 
            this.unos_krajnajma_button.Location = new System.Drawing.Point(44, 76);
            this.unos_krajnajma_button.Name = "unos_krajnajma_button";
            this.unos_krajnajma_button.Size = new System.Drawing.Size(75, 23);
            this.unos_krajnajma_button.TabIndex = 2;
            this.unos_krajnajma_button.Text = "Unos";
            this.unos_krajnajma_button.UseVisualStyleBackColor = true;
            this.unos_krajnajma_button.Click += new System.EventHandler(this.unos_krajnajma_button_Click);
            // 
            // broj_najma_textbox
            // 
            this.broj_najma_textbox.Location = new System.Drawing.Point(7, 18);
            this.broj_najma_textbox.Name = "broj_najma_textbox";
            this.broj_najma_textbox.ReadOnly = true;
            this.broj_najma_textbox.Size = new System.Drawing.Size(47, 20);
            this.broj_najma_textbox.TabIndex = 0;
            this.broj_najma_textbox.Text = "# najma";
            // 
            // naziv_vozila_textbox
            // 
            this.naziv_vozila_textbox.Location = new System.Drawing.Point(61, 18);
            this.naziv_vozila_textbox.Name = "naziv_vozila_textbox";
            this.naziv_vozila_textbox.ReadOnly = true;
            this.naziv_vozila_textbox.Size = new System.Drawing.Size(95, 20);
            this.naziv_vozila_textbox.TabIndex = 12;
            this.naziv_vozila_textbox.Text = "Naziv Vozila";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle11;
            this.id.HeaderText = "#";
            this.id.Name = "id";
            // 
            // ime
            // 
            this.ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ime.DataPropertyName = "ime";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ime.DefaultCellStyle = dataGridViewCellStyle12;
            this.ime.HeaderText = "Ime";
            this.ime.Name = "ime";
            // 
            // prezime
            // 
            this.prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prezime.DataPropertyName = "prezime";
            this.prezime.HeaderText = "Prezime";
            this.prezime.Name = "prezime";
            // 
            // oib
            // 
            this.oib.DataPropertyName = "oib";
            this.oib.HeaderText = "OIB";
            this.oib.Name = "oib";
            // 
            // naziv
            // 
            this.naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.naziv.DataPropertyName = "naziv";
            this.naziv.HeaderText = "Naziv Vozila";
            this.naziv.Name = "naziv";
            // 
            // registracija
            // 
            this.registracija.DataPropertyName = "registracija";
            this.registracija.HeaderText = "Registracija";
            this.registracija.Name = "registracija";
            // 
            // vrijemeizn
            // 
            this.vrijemeizn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vrijemeizn.DataPropertyName = "vrijemeizn";
            this.vrijemeizn.HeaderText = "Vrijeme iznajmljivanja";
            this.vrijemeizn.Name = "vrijemeizn";
            // 
            // vrijemevr
            // 
            this.vrijemevr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vrijemevr.DataPropertyName = "vrijemevr";
            this.vrijemevr.HeaderText = "Vrijeme vraćanja";
            this.vrijemevr.Name = "vrijemevr";
            // 
            // cijena
            // 
            this.cijena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cijena.DataPropertyName = "cijena";
            this.cijena.HeaderText = "Cijena iznajmljivanja";
            this.cijena.Name = "cijena";
            // 
            // unos_vr_label
            // 
            this.unos_vr_label.AutoSize = true;
            this.unos_vr_label.Location = new System.Drawing.Point(41, 108);
            this.unos_vr_label.Name = "unos_vr_label";
            this.unos_vr_label.Size = new System.Drawing.Size(0, 13);
            this.unos_vr_label.TabIndex = 20;
            this.unos_vr_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // unos_novi_label
            // 
            this.unos_novi_label.AutoSize = true;
            this.unos_novi_label.Location = new System.Drawing.Point(120, 103);
            this.unos_novi_label.Name = "unos_novi_label";
            this.unos_novi_label.Size = new System.Drawing.Size(0, 13);
            this.unos_novi_label.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Potvrda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEvidencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.izracuncijene_group);
            this.Controls.Add(this.kraj_najma_group);
            this.Controls.Add(this.refresh_prikaz);
            this.Controls.Add(this.unos_najma_group);
            this.Controls.Add(this.unos_vozilaiosoba_group);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEvidencija";
            this.Text = "Evidencija Najma";
            this.Load += new System.EventHandler(this.frmEvidencija_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.izracuncijene_group.ResumeLayout(false);
            this.izracuncijene_group.PerformLayout();
            this.unos_vozilaiosoba_group.ResumeLayout(false);
            this.unos_najma_group.ResumeLayout(false);
            this.unos_najma_group.PerformLayout();
            this.kraj_najma_group.ResumeLayout(false);
            this.kraj_najma_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Unos_osoba_combobox;
        private System.Windows.Forms.ComboBox Unos_vozilo_combobox;
        private System.Windows.Forms.Button unos_najam_button;
        private System.Windows.Forms.Button refresh_prikaz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button osobe_button;
        private System.Windows.Forms.Button vozila_button;
        private System.Windows.Forms.Button izracunnajma_button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox izracun_vozilo_combobox;
        private System.Windows.Forms.GroupBox izracuncijene_group;
        private System.Windows.Forms.GroupBox unos_vozilaiosoba_group;
        private System.Windows.Forms.GroupBox unos_najma_group;
        private System.Windows.Forms.GroupBox kraj_najma_group;
        private System.Windows.Forms.Button unos_krajnajma_button;
        private System.Windows.Forms.TextBox broj_najma_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datumizn_dateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox naziv_vozila_textbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn oib;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn registracija;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeizn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemevr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena;
        private System.Windows.Forms.Label unos_novi_label;
        private System.Windows.Forms.Label unos_vr_label;
        private System.Windows.Forms.Button button1;
    }
}