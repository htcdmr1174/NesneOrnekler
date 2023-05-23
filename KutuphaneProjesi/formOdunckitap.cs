using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class formOdunckitap : Form
    {
        public formOdunckitap()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        String komutSatiri;

        private void formOdunckitap_Load(object sender, EventArgs e)
        {
            KitapListele();
            KitapYukle();
        }
        public void KitapYukle()
        {
            try
            {
                komutSatiri = "select * from kitaplar where kitap_id not in (select kitap_id from odunc_kitaplar where teslm_tarihi IS NULL";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                comboKitap.DataSource = dataTable;
                comboKitap.ValueMember = "kitap_id";
                comboKitap.DisplayMember = "kitap_adi";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void KitapListele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "Select id,ogrenci_no,ad,soyad,,kitap_adi,verilis_tarihi,teslim_tarihi,aciklama" +
                "where ogr_no=ogrenci-no and kitaplar.kitap_id = odunc_kitap.kitap_id";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                gridKitap.DataSource = dataTable;

                gridKitap.Columns["id"].HeaderText = "ID";
                gridKitap.Columns["id"].Width = 30;
                gridKitap.Columns["ogrenci_no"].HeaderText = "Ögrenci No";
                gridKitap.Columns["ogrenci_no"].Width = 40;
                gridKitap.Columns["ad"].HeaderText = "Ad";
                gridKitap.Columns["ad"].Width = 70;
                gridKitap.Columns["soyad"].HeaderText = "Soyad";
                gridKitap.Columns["soyad"].Width = 70;
                gridKitap.Columns["kitap_adi"].HeaderText = "Kitap Adı";
                gridKitap.Columns["kitap_adi"].Width = 100;
                gridKitap.Columns["verilis_tarihi"].HeaderText = "Veriliş Tarihi";
                gridKitap.Columns["verilis_tarihi"].Width = 70;
                gridKitap.Columns["teslim_tarihi"].HeaderText = "Teslim Tarihi";
                gridKitap.Columns["teslim_tarihi"].Width = 70;
                gridKitap.Columns["aciklama"].HeaderText = "Açıklama";
                gridKitap.Columns["aciklama"].Width = 70;




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btnkitapVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();

                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO odunc_kitaplar(ogr_no,kitap_id,verilis_tarihi,acıklama) " +
                    "VALUES (@ogr_no,@kitap_id,@verilis_terihi,@acıklama)";
                komut.Parameters.AddWithValue("ogr_no", int.Parse(txtogrencino.Text));
                komut.Parameters.AddWithValue("kitap_id", int.Parse(comboKitap.Text));
                komut.Parameters.AddWithValue("verilis_tarihi", DateTime.Now.ToString("yyyy/MM/dd");
                komut.Parameters.AddWithValue("aciklama", txtaciklama.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı ", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                KitapListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
            public void Temizle()
            {
                txtaciklama.Clear();
                txtogrencino.Clear();
                
            }

        private void gridKitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtaciklama.Text = gridKitap.CurrentRow.Cells["aciklama"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();

                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText "DELETE FROM odunc_kitaplar WHERE id =@id";
                komut.Parameters.AddWithValue("@id", gridKitap.CurrentRow.Cells["id"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı ", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                KitapListele();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }    }
    
