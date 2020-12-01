using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace pbd_29_UbayaFriedChicken
{
    public class Reward
    {
        #region reward
        private string idReward;
        private string nama;
        private string barang;
        private int batas_minimal;
        #endregion

        #region constructor
        public Reward(string idReward, string nama, string barang, int batas_minimal)
        {
            this.IdReward = idReward;
            this.Nama = nama;
            this.Barang = barang;
            this.Batas_minimal = batas_minimal;
        }
        #endregion

        #region properties
        public string IdReward { get => idReward; set => idReward = value; }
         public string Nama
        {
            get => nama;
            set
            {
                    nama = value;
            }
        }

        public string Barang { get => barang; set => barang = value; }
        public int Batas_minimal
        {
            get => batas_minimal;
            set
            {
                if(value < 0)
                {
                    throw new Exception("Batas minimal tidak boleh dibawah 0!");
                }
                else
                {
                    batas_minimal = value;
                }
            }
        }

        #endregion

        #region method
        public static void TambahData(Reward r)
        {
            string sql = "Insert into Reward(IdReward, nama, barang, batas_minimal) values('" + r.idReward + "','" + r.Nama.Replace("\\'", "") + "','" + r.Barang.Replace("\\'", "") + "','" + r.Batas_minimal + "')";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void UbahData(Reward r)
        {
            string sql = "Update Reward set Nama='" + r.Nama.Replace("\\'", "") + "', barang='" + r.Barang.Replace("\\'", "") + "', batas_minimal='" + r.Batas_minimal + "' where IdReward='" + r.IdReward + "'";
            Koneksi.JalankanPerintahDML(sql);
        }

        public static void HapusData(Reward r)
        {
            string sql = "Delete from Reward where IdReward ='" + r.IdReward + "'";
            Koneksi.JalankanPerintahDML(sql);
        }
        public static List<Reward> BacaData(string k, string nk)
        {
            string sql = "";
            if (k == "")
            {
                sql = "select IdReward, nama as 'Nama Reward', barang as 'Barang', batas_minimal as 'Batas Minimal'" +
                    " from reward";
            }
            else
            {
                sql = "select IdReward, nama as 'Nama Reward', barang as 'Barang', batas_minimal as 'Batas Minimal'" +
                    " from reward where " + k + " like '%" + nk + "%'";
            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Reward> listReward = new List<Reward>();
            while (hasil.Read() == true)
            {
                Reward r = new Reward(hasil.GetValue(0).ToString(), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), int.Parse(hasil.GetValue(3).ToString()));                 
                listReward.Add(r);
            }
            return listReward;
        }

        public static string GenerateKode()
        {
            string sql = "select max(IdReward) from reward";
            string hasilkode = "";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    int kodebaru = int.Parse(hasil.GetValue(0).ToString()) + 1;
                    hasilkode = kodebaru.ToString().PadLeft(2, '0');
                }
                else
                {
                    hasilkode = "01";
                }
            }
            
            return hasilkode;
        }
        #endregion
    }
}