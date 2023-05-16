using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class formOgrenci : Form
    {


        public formOgrenci()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        String komutSatiri;




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();

                }
                komutSatiri = "DELETE FROM ogrenciler WHERE ogrenci_no =@no";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@no", gridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("işlem başarılı ", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void formOgrenci_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "Select * Form ogrencileri";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridOgrenci.DataSource = dataTable;
                gridOgrenci.Columns["ogrenci_no"].HeaderText = "Öğrenci Numarası";
                gridOgrenci.Columns["ad"].HeaderText = "ad";
                gridOgrenci.Columns["soyad"].HeaderText = "soyad";
                gridOgrenci.Columns["sınıf"].HeaderText = "Sınıf";
                gridOgrenci.Columns["cinsiyet"].HeaderText = "cinsiyet";
                gridOgrenci.Columns["telefon"].HeaderText = "telefon Numarası";


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
                komutSatiri = "INSERT INTO ogrenciler (ogrenci_no, ad,soyad,sınıf,cinsiyet,telefon) VALUES (@no,@ad,@soyad,@sınıf,@cinsiyet,@telefon)";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@no", int.Parse(txtNo.Text));
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@sınıf", int.Parse(comboSinif.SelectedItem.ToString()));
                komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);


                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı ", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtNo.Clear();
            txtTelefon.Clear();
        }

        private void gridOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNo.Text = gridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString();
                txtAd.Text = gridOgrenci.CurrentRow.Cells["ad"].Value.ToString();
                txtSoyad.Text = gridOgrenci.CurrentRow.Cells["soyad"].Value.ToString();
                txtTelefon.Text = gridOgrenci.CurrentRow.Cells["sinif"].Value.ToString();
                comboSinif.Text = gridOgrenci.CurrentRow.Cells["cinsiyet"].Value.ToString();
                comboCinsiyet.Text = gridOgrenci.CurrentRow.Cells["cinsiyet"].Value.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu ", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                komutSatiri = "UPDATE ogrenciler SET ad=@ad,soyad=@soyad,sinif=@Sinif,cinsiyet=@cinsiyet,telefo=@telefon where ogrenci_no=@no";
                komut.Parameters.AddWithValue("@no", int.Parse(txtNo.Text));
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@sınıf", int.Parse(comboSinif.SelectedItem.ToString()));
                komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı ", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Listele();

            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu ", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtOgrenciAra_TextChanged(object sender, EventArgs e)
        {
            OgrenciArama(txtOgrenciAra.Text);
        }

        public void OgrenciArama(string aranacakkelime)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "Select * From ogrenciler Where ad LİKE '" + aranacakkelime + "%'";
                MySqlDataAdapter dataAdapter = new MySqlAdapter(komut);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                baglanti.Close();
                gridOgrenci.DataSource = dataTable;



            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu ", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
