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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.unos_najam_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_najam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeosobe_najam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime_najam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv_najam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeizn_najam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemevr_najam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijena_najam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osobe_button = new System.Windows.Forms.Button();
            this.vozila_button = new System.Windows.Forms.Button();
            this.izracunnajma_button = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.izracuncijene_group = new System.Windows.Forms.GroupBox();
            this.unos_vozilaiosoba_group = new System.Windows.Forms.GroupBox();
            this.unos_najma_group = new System.Windows.Forms.GroupBox();
            this.kraj_najma_group = new System.Windows.Forms.GroupBox();
            this.unos_krajnajma_button = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.izracuncijene_group.SuspendLayout();
            this.unos_vozilaiosoba_group.SuspendLayout();
            this.unos_najma_group.SuspendLayout();
            this.kraj_najma_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Osoba";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(145, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Vozilo";
            // 
            // unos_najam_button
            // 
            this.unos_najam_button.Location = new System.Drawing.Point(100, 87);
            this.unos_najam_button.Name = "unos_najam_button";
            this.unos_najam_button.Size = new System.Drawing.Size(75, 23);
            this.unos_najam_button.TabIndex = 4;
            this.unos_najam_button.Text = "Unos";
            this.unos_najam_button.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Osvježi ispis";
            this.button2.UseVisualStyleBackColor = true;
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_najam,
            this.imeosobe_najam,
            this.prezime_najam,
            this.naziv_najam,
            this.vrijemeizn_najam,
            this.vrijemevr_najam,
            this.cijena_najam});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(787, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // id_najam
            // 
            this.id_najam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.id_najam.DefaultCellStyle = dataGridViewCellStyle7;
            this.id_najam.HeaderText = "#";
            this.id_najam.Name = "id_najam";
            this.id_najam.ReadOnly = true;
            // 
            // imeosobe_najam
            // 
            this.imeosobe_najam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.imeosobe_najam.DefaultCellStyle = dataGridViewCellStyle8;
            this.imeosobe_najam.HeaderText = "Ime";
            this.imeosobe_najam.Name = "imeosobe_najam";
            this.imeosobe_najam.ReadOnly = true;
            // 
            // prezime_najam
            // 
            this.prezime_najam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prezime_najam.HeaderText = "Prezime";
            this.prezime_najam.Name = "prezime_najam";
            this.prezime_najam.ReadOnly = true;
            // 
            // naziv_najam
            // 
            this.naziv_najam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.naziv_najam.HeaderText = "Naziv Vozila";
            this.naziv_najam.Name = "naziv_najam";
            this.naziv_najam.ReadOnly = true;
            // 
            // vrijemeizn_najam
            // 
            this.vrijemeizn_najam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vrijemeizn_najam.HeaderText = "Vrijeme iznajmljivanja";
            this.vrijemeizn_najam.Name = "vrijemeizn_najam";
            this.vrijemeizn_najam.ReadOnly = true;
            // 
            // vrijemevr_najam
            // 
            this.vrijemevr_najam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vrijemevr_najam.HeaderText = "Vrijeme vraćanja";
            this.vrijemevr_najam.Name = "vrijemevr_najam";
            this.vrijemevr_najam.ReadOnly = true;
            // 
            // cijena_najam
            // 
            this.cijena_najam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cijena_najam.HeaderText = "Cijena iznajmljivanja";
            this.cijena_najam.Name = "cijena_najam";
            this.cijena_najam.ReadOnly = true;
            // 
            // osobe_button
            // 
            this.osobe_button.Location = new System.Drawing.Point(27, 31);
            this.osobe_button.Name = "osobe_button";
            this.osobe_button.Size = new System.Drawing.Size(75, 23);
            this.osobe_button.TabIndex = 7;
            this.osobe_button.Text = "Osobe";
            this.osobe_button.UseVisualStyleBackColor = true;
            this.osobe_button.Click += new System.EventHandler(this.osobe_button_Click);
            // 
            // vozila_button
            // 
            this.vozila_button.Location = new System.Drawing.Point(27, 88);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2016, 2, 11, 10, 13, 47, 0);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "Trajanje iznajmljivanja";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(20, 19);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(160, 21);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.Text = "Vozilo";
            this.comboBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox3_MouseClick);
            // 
            // izracuncijene_group
            // 
            this.izracuncijene_group.Controls.Add(this.comboBox3);
            this.izracuncijene_group.Controls.Add(this.textBox2);
            this.izracuncijene_group.Controls.Add(this.izracunnajma_button);
            this.izracuncijene_group.Location = new System.Drawing.Point(599, 12);
            this.izracuncijene_group.Name = "izracuncijene_group";
            this.izracuncijene_group.Size = new System.Drawing.Size(200, 127);
            this.izracuncijene_group.TabIndex = 16;
            this.izracuncijene_group.TabStop = false;
            this.izracuncijene_group.Text = "Izračun cijene";
            // 
            // unos_vozilaiosoba_group
            // 
            this.unos_vozilaiosoba_group.Controls.Add(this.osobe_button);
            this.unos_vozilaiosoba_group.Controls.Add(this.vozila_button);
            this.unos_vozilaiosoba_group.Location = new System.Drawing.Point(458, 12);
            this.unos_vozilaiosoba_group.Name = "unos_vozilaiosoba_group";
            this.unos_vozilaiosoba_group.Size = new System.Drawing.Size(135, 127);
            this.unos_vozilaiosoba_group.TabIndex = 17;
            this.unos_vozilaiosoba_group.TabStop = false;
            this.unos_vozilaiosoba_group.Text = "Unos vozila i osoba";
            // 
            // unos_najma_group
            // 
            this.unos_najma_group.Controls.Add(this.comboBox1);
            this.unos_najma_group.Controls.Add(this.comboBox2);
            this.unos_najma_group.Controls.Add(this.dateTimePicker1);
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
            this.kraj_najma_group.Controls.Add(this.unos_krajnajma_button);
            this.kraj_najma_group.Controls.Add(this.textBox3);
            this.kraj_najma_group.Controls.Add(this.textBox1);
            this.kraj_najma_group.Location = new System.Drawing.Point(290, 13);
            this.kraj_najma_group.Name = "kraj_najma_group";
            this.kraj_najma_group.Size = new System.Drawing.Size(162, 126);
            this.kraj_najma_group.TabIndex = 19;
            this.kraj_najma_group.TabStop = false;
            this.kraj_najma_group.Text = "Vozilo vraćeno";
            // 
            // unos_krajnajma_button
            // 
            this.unos_krajnajma_button.Location = new System.Drawing.Point(49, 87);
            this.unos_krajnajma_button.Name = "unos_krajnajma_button";
            this.unos_krajnajma_button.Size = new System.Drawing.Size(75, 23);
            this.unos_krajnajma_button.TabIndex = 2;
            this.unos_krajnajma_button.Text = "Unos";
            this.unos_krajnajma_button.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Vrijeme završetka najma";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "# najma";
            // 
            // frmEvidencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 469);
            this.Controls.Add(this.kraj_najma_group);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.unos_najma_group);
            this.Controls.Add(this.unos_vozilaiosoba_group);
            this.Controls.Add(this.izracuncijene_group);
            this.Controls.Add(this.panel1);
            this.Name = "frmEvidencija";
            this.Text = "Evidencija Najma";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.izracuncijene_group.ResumeLayout(false);
            this.izracuncijene_group.PerformLayout();
            this.unos_vozilaiosoba_group.ResumeLayout(false);
            this.unos_najma_group.ResumeLayout(false);
            this.kraj_najma_group.ResumeLayout(false);
            this.kraj_najma_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button unos_najam_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button osobe_button;
        private System.Windows.Forms.Button vozila_button;
        private System.Windows.Forms.Button izracunnajma_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_najam;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeosobe_najam;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime_najam;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_najam;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeizn_najam;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemevr_najam;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijena_najam;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox izracuncijene_group;
        private System.Windows.Forms.GroupBox unos_vozilaiosoba_group;
        private System.Windows.Forms.GroupBox unos_najma_group;
        private System.Windows.Forms.GroupBox kraj_najma_group;
        private System.Windows.Forms.Button unos_krajnajma_button;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
    }
}