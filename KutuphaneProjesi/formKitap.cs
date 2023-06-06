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
    public partial class formKitap : Form
    {
        public formKitap()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        String komutSatiri;

        private void formKitap_Load(object sender, EventArgs e)
        {
            KitapTurYukle();
            KitapListele();
        }
        private void KitapTurYukle()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "Select *From kitap_tur";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                comboKitapTur.DataSource = dataTable;
                comboKitapTur.ValueMember = "tur_id";
                comboKitapTur.DisplayMember = "tur_id";

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
                komutSatiri = "Select kitap_id, tur_adi, kitap_adi, yazar, yayinevi, sayfa_sayisi From kitaplar,kitap-turleri where kitaplar.tur_id=kitap_turleri.tur_id";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                gridKitap.DataSource = dataTable;

                gridKitap.Columns["kitap_id"].HeaderText = "ID";
                gridKitap.Columns["kitap_id"].Width = 20;
                gridKitap.Columns["tur_adi"].HeaderText = "tür";
                gridKitap.Columns["tur_adi"].Width = 30;
                gridKitap.Columns["kitap_adi"].HeaderText = "Adı";
                gridKitap.Columns["kitap_adi"].Width = 90;
                gridKitap.Columns["yazar"].HeaderText = "yazar";
                gridKitap.Columns["yazar"].Width = 80;
                gridKitap.Columns["yayinevi"].HeaderText = "yayinevi";
                gridKitap.Columns["yayinevi"].Width = 80;
                gridKitap.Columns["sayfa_sayisi"].HeaderText = "Sayfa Sayisi";
                gridKitap.Columns["sayfa_sayisi"].Width = 50;




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }

                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO kitaplar (tur_id,kitap_adi,yazar,yayinevi,sayfa_sayisi)" +
                "VALUES (@tur_id,@kitap_adi,@yazar,@yayinevi,@sayfa_sayisi)";
                komut.Parameters.AddWithValue("@tur_id", int.Parse(comboKitapTur.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@kitap_adi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
                komut.Parameters.AddWithValue("@sayfa_sayisi", int.Parse(txtSayfaSayisi.Text));

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
                txtKitapAdi.Clear();
                txtSayfaSayisi.Clear();
                txtYayinevi.Clear();
                txtYazar.Clear();
            }

        private void gridKitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtKitapAdi.Text = gridKitap.CurrentRow.Cells["kitap_adi"].Value.ToString();
                txtSayfaSayisi .Text = gridKitap .CurrentRow.Cells["sayfa_sayisi"].Value.ToString();
                txtYayinevi .Text = gridKitap.CurrentRow.Cells["yayinevi"].Value.ToString();
                txtYazar .Text = gridKitap.CurrentRow.Cells["yazar"].Value.ToString();
                comboKitapTur.Text = gridKitap.CurrentRow.Cells["tur_adi"].Value.ToString();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }





        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Connection = baglanti;
                komut.CommandText = "DELETE FROM kitaplar WHERE kitap_id = @kitap_id";


                komut.Parameters.AddWithValue("@kitap_id", gridKitap.CurrentRow.Cells["kitap_id"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("işlem başarılı ", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                KitapListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }

                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO kitaplar (tur_id,kitap_adi,yazar,yayinevi,sayfa_sayisi)" +
                "VALUES (@tur_id,@kitap_adi,@yazar,@yayinevi,@sayfa_sayisi)";
                komut.Parameters.AddWithValue("@tur-id", int.Parse(comboKitapTur.SelectedValue.ToString()));
                komut.Parameters.AddWithValue("@kitap_adi", txtKitapAdi.Text);
                komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
                komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
                komut.Parameters.AddWithValue("@sayfa_sayisi", int.Parse(txtSayfaSayisi.Text));

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

        private void txtKitapAra_TextChanged(object sender, EventArgs e)
        {
            KitapArama(txtKitapAra.Text);
            
        }

        private void KitapArama(string text)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutSatiri = "Select kitap_id,tur_adi,yazar,yayinevi,sayfa_sayisi, From kitaplar,Kitap_türleri" +
                "where kitaplar.tur_id=kitap_türleri.tur_id and kitap_adi LIKE '" + text + "&'";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                baglanti.Close();
                gridKitap.DataSource = dataTable;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
       
}
