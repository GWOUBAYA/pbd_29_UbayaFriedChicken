using pbd_29_UbayaFriedChicken;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UbayaFriedChicken_Form
{
    public partial class FormTambahNotaJual : Form
    {
        FormUtama formUtama;
        List<Pelanggan> listPelanggan = new List<Pelanggan>();
        List<Produk> listProduk = new List<Produk>();
        NotaJual notaJual;

        public FormTambahNotaJual()
        {
            InitializeComponent();
        }

        private void FormTambahNotaJual_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.Owner.MdiParent;

            //generate Id Nota baru
            textBoxIdNotaJual.Text = NotaJual.GenerateIdNota();

            //agar Id Nota tidak bisa diganti
            textBoxIdNotaJual.Enabled = false;

            //default tanggal hari ini
            dateTimePickerTanggal.Value = DateTime.Now;

            //tampilkan pegawai yang sedang login
            labelIdPegawai.Text = formUtama.labelIDUser.Text;
            labelNamaPegawai.Text = formUtama.labelNamaUser.Text;

            //tampilkan data pelanggan di combobox menggunakan data binding
            listPelanggan = Pelanggan.BacaData("", "");
            comboBoxPelanggan.DataSource = listPelanggan;
            comboBoxPelanggan.DisplayMember = "Nama";

            //tambahkan kolom di datagrid
            FormatDataGrid();

            //buat panjang max dari textbox barcode = 13 karakter
            textBoxId.MaxLength = 5;

        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormDaftarNotaJual formDaftarNotaJual = (FormDaftarNotaJual)this.Owner;
            formDaftarNotaJual.FormDaftarNotaJual_Load(buttonKeluar, e);
            formDaftarNotaJual.Enabled = true;
            this.Close();
        }

        private void FormatDataGrid()
        {
            dataGridViewProduk.Columns.Clear();

            //parameter 1 berisi nama untuk koding
            //parameter 2 berisi nama yang akan ditampilkan
            dataGridViewProduk.Columns.Add("IdProduk", "Id Produk");
            dataGridViewProduk.Columns.Add("NamaProduk", "Nama Produk");
            dataGridViewProduk.Columns.Add("HargaJual", "Harga Jual");
            dataGridViewProduk.Columns.Add("Jumlah", "Jumlah");
            dataGridViewProduk.Columns.Add("SubTotal", "SubTotal");

            //auto resize untuk ukuran kolom
            dataGridViewProduk.Columns["IdProduk"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewProduk.Columns["NamaProduk"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewProduk.Columns["HargaJual"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewProduk.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewProduk.Columns["SubTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //perataan tulisan
            dataGridViewProduk.Columns["HargaJual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewProduk.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewProduk.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //pemisah ribuan 
            dataGridViewProduk.Columns["HargaJual"].DefaultCellStyle.Format = "#,###";
            dataGridViewProduk.Columns["SubTotal"].DefaultCellStyle.Format = "#,###";

            //agar data grid tidak dapat diisi atau diganti oleh user
            dataGridViewProduk.AllowUserToAddRows = false;
            dataGridViewProduk.ReadOnly = true;
        }

        private void comboBoxPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPelanggan.SelectedIndex != -1)
            {
                Pelanggan pelangganDipilih = (Pelanggan)comboBoxPelanggan.SelectedItem;
                labelAlamatPelanggan.Text = pelangganDipilih.Alamat;
            }
            else
            {
                labelAlamatPelanggan.Text = "";
            }
        }
        private int HitungGrandTotalNota()
        {
            int grandTotal = 0;
            for (int i = 0; i < dataGridViewProduk.Rows.Count; i++)
            {
                //row urutan ke berapa
                //cells = untuk hitung kolom yang mana
                int subTotal = int.Parse(dataGridViewProduk.Rows[i].Cells["SubTotal"].Value.ToString());
                grandTotal += subTotal;
            }
            return grandTotal;
        }

        private void textBoxBarcode_TextChanged(object sender, EventArgs e)
        {
            //jika barcode telah selesai diketik
            if (textBoxId.Text.Length == textBoxId.MaxLength)
            {
                //cari produk dengan barcode tersebut di tabel produk
                listProduk = Produk.BacaData("IdProduk", textBoxId.Text);

                //jika terdapat produk dengan barcode tersebut
                if (listProduk.Count > 0)
                {
                    //tampilkan Id, nama, dan harga jual dari produk tersebut
                    labelNamaProduk.Text = listProduk[0].Nama;
                    labelHarga.Text = listProduk[0].HargaJual.ToString();

                    //fokus ke textbox jumlah dan default nya harus 1
                    textBoxJumlah.Text = "1";
                    textBoxJumlah.Focus();
                }
                else
                {
                    MessageBox.Show("Produk dengan id tersebut tidak ditemukan");
                }
            }
        }

        private void textBoxJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int subTotal = int.Parse(labelHarga.Text) * int.Parse(textBoxJumlah.Text);

                //tambahkan ke dataGridView
                dataGridViewProduk.Rows.Add(textBoxId.Text,labelNamaProduk.Text, labelHarga.Text, textBoxJumlah.Text, subTotal);

                //hitung grandtotal nota
                labelGrandTotal.Text = HitungGrandTotalNota().ToString("#,###");

                //kosongi inputan 
                textBoxId.Text = "";
                labelNamaProduk.Text = "";
                labelHarga.Text = "";
                textBoxJumlah.Text = "";
                textBoxId.Focus();
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Pelanggan pelangganDipilih = (Pelanggan)comboBoxPelanggan.SelectedItem;
                List<Pegawai> listPegawai = Pegawai.BacaData("IdPegawai",labelIdPegawai.Text);
                //buat objek nota jual
                notaJual = new NotaJual(textBoxIdNotaJual.Text, dateTimePickerTanggal.Value,
                    pelangganDipilih, listPegawai[0]);
                int grandTotal = 0;
                List<Produk> listProdukTerjual = new List<Produk>();
                //tambahkan detil produk yang terjual ke dalam listDetilProduk di nota jual
                for (int i = 0; i < dataGridViewProduk.Rows.Count; i++)
                {
                    listProdukTerjual = Produk.BacaData("IdProduk", dataGridViewProduk.Rows[i].Cells["IdProduk"].Value.ToString());
                    notaJual.TambahNotaJualDetil(listProdukTerjual[0],
                        int.Parse(dataGridViewProduk.Rows[i].Cells["HargaJual"].Value.ToString()),
                        int.Parse(dataGridViewProduk.Rows[i].Cells["Jumlah"].Value.ToString()));
                    grandTotal = grandTotal + (int.Parse(dataGridViewProduk.Rows[i].Cells["HargaJual"].Value.ToString()) * int.Parse(dataGridViewProduk.Rows[i].Cells["Jumlah"].Value.ToString()));
                }

                List<Reward> listReward = Reward.BacaData("", "");
                foreach (Reward reward in listReward)
                {
                    if (reward.Batas_minimal <= grandTotal)
                    {
                        notaJual.TambahRewardNotaJual(reward);
                    }
                }
                    //simpan ke nota jual
                    NotaJual.TambahData(notaJual);

                MessageBox.Show("Data nota jual telah tersimpan.", "Informasi");

                /*
                //jika ingin ketika klik button simpan maka otomatis mencetak, maka hapus comment code di bawah ini
                //panggil event handler buttonCetak_Click
                buttonCetak_Click(sender, e);
                */
            }
            catch (Exception exc)
            {
                if (exc.Message != "The current TransactionScope is already complete.")
                {
                    MessageBox.Show("Terjadi kesalahan. Pesan kesalahan : " + exc.Message);
                }
                else
                {
                    MessageBox.Show("Transaksi Berhasil");
                }
               
            }

        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            try
            {
                NotaJual.CetakNota("IdNota", textBoxIdNotaJual.Text, "nota_jual.txt", new Font("Courier New", 12));
                MessageBox.Show("Nota jual telah tercetak");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Nota jual gagal dicetak. Pesan kesalahan : " + exc.Message);
            }
        }
    }
}


