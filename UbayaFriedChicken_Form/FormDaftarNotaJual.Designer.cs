﻿namespace UbayaFriedChicken_Form
{
    partial class FormDaftarNotaJual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDaftarNotaJual));
            this.buttonCetak = new System.Windows.Forms.Button();
            this.panelWarna = new System.Windows.Forms.Panel();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.labelKeterangan = new System.Windows.Forms.Label();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.labelWarna = new System.Windows.Forms.Label();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.panelWarna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCetak
            // 
            this.buttonCetak.BackColor = System.Drawing.Color.White;
            this.buttonCetak.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetak.ForeColor = System.Drawing.Color.Red;
            this.buttonCetak.Location = new System.Drawing.Point(312, 344);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(86, 26);
            this.buttonCetak.TabIndex = 51;
            this.buttonCetak.Text = "CETAK";
            this.buttonCetak.UseVisualStyleBackColor = false;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // panelWarna
            // 
            this.panelWarna.BackColor = System.Drawing.Color.Transparent;
            this.panelWarna.Controls.Add(this.textBoxCari);
            this.panelWarna.Controls.Add(this.comboBoxCari);
            this.panelWarna.Controls.Add(this.labelKeterangan);
            this.panelWarna.Location = new System.Drawing.Point(11, 55);
            this.panelWarna.Name = "panelWarna";
            this.panelWarna.Size = new System.Drawing.Size(487, 36);
            this.panelWarna.TabIndex = 45;
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(277, 10);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(191, 20);
            this.textBoxCari.TabIndex = 2;
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.BackColor = System.Drawing.Color.White;
            this.comboBoxCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCari.FormattingEnabled = true;
            this.comboBoxCari.Items.AddRange(new object[] {
            "ID Nota",
            "Tanggal",
            "ID Pelanggan",
            "ID Pegawai"});
            this.comboBoxCari.Location = new System.Drawing.Point(132, 10);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(139, 21);
            this.comboBoxCari.TabIndex = 1;
            // 
            // labelKeterangan
            // 
            this.labelKeterangan.AutoSize = true;
            this.labelKeterangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeterangan.Location = new System.Drawing.Point(14, 13);
            this.labelKeterangan.Name = "labelKeterangan";
            this.labelKeterangan.Size = new System.Drawing.Size(112, 13);
            this.labelKeterangan.TabIndex = 0;
            this.labelKeterangan.Text = "Cari Berdasarkan :";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(11, 107);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(487, 231);
            this.dataGridViewData.TabIndex = 46;
            // 
            // labelWarna
            // 
            this.labelWarna.BackColor = System.Drawing.Color.Red;
            this.labelWarna.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarna.ForeColor = System.Drawing.Color.White;
            this.labelWarna.Location = new System.Drawing.Point(11, 8);
            this.labelWarna.Name = "labelWarna";
            this.labelWarna.Size = new System.Drawing.Size(487, 35);
            this.labelWarna.TabIndex = 44;
            this.labelWarna.Text = "DAFTAR NOTA JUAL";
            this.labelWarna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.White;
            this.buttonHapus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.ForeColor = System.Drawing.Color.Red;
            this.buttonHapus.Location = new System.Drawing.Point(212, 344);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(94, 26);
            this.buttonHapus.TabIndex = 49;
            this.buttonHapus.Text = "HAPUS";
            this.buttonHapus.UseVisualStyleBackColor = false;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.White;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.Red;
            this.buttonKeluar.Location = new System.Drawing.Point(404, 344);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(94, 26);
            this.buttonKeluar.TabIndex = 48;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.White;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.Red;
            this.buttonTambah.Location = new System.Drawing.Point(12, 344);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(94, 26);
            this.buttonTambah.TabIndex = 47;
            this.buttonTambah.Text = "TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // FormDaftarNotaJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(508, 379);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.panelWarna);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.labelWarna);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonTambah);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDaftarNotaJual";
            this.Text = "Daftar Nota Jual";
            this.Load += new System.EventHandler(this.FormDaftarNotaJual_Load);
            this.panelWarna.ResumeLayout(false);
            this.panelWarna.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.Panel panelWarna;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.Label labelKeterangan;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Label labelWarna;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonTambah;
    }
}