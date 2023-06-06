using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Sinav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VeriTabaniİslemleri vtIslemleri = new VeriTabaniİslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        String komutSatiri;


        private void Form1_Load(object sender, EventArgs e)
        {
            {
                Listele();

            }
        }
        public void Listele()
        {
            try
            {
                komutSatiri = "select * from urunler";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.Columns["id"].HeaderText = "id";
                dataGridView1.Columns["urun_adi"].HeaderText = "urun_adi";
                dataGridView1.Columns["fiyat"].HeaderText = "fiyat";
                dataGridView1.Columns["adet"].HeaderText = "adet";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutSatiri = "INSERT INTO urunler (urun_adi,fiyat,adet) VALUES (@urun_adi,@fiyat,@adet)";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@urun_adi", txtUrunadı.Text);
                komut.Parameters.AddWithValue("@fiyat", int.Parse(txtFiyat.Text.ToString()));
                komut.Parameters.AddWithValue("@adet", int.Parse(txtAdet.Text.ToString()));

                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("İşlem Başarılı ", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Listele();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Temizle()
        {
            txtAdet.Clear();
            txtUrunadı.Clear();
            txtFiyat.Clear();
            txtAra.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();

                }
                komutSatiri = "DELETE FROM urunler WHERE id=@id";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["id"].Value.ToString());
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

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komutSatiri = "UPDATE urunler SET urun_adi=@urun_adi,fiyat=@fiyat,adet=@adet where urun_adi=@urun_adi";
                komut.Parameters.AddWithValue("@fiyat", int.Parse(txtFiyat.Text.ToString()));
                komut.Parameters.AddWithValue("@adet", int.Parse(txtAdet.Text.ToString()));
                komut.Parameters.AddWithValue("@urun_adi", txtUrunadı.Text);

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

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            UrunArama(txtAra.Text);
        }

        public void UrunArama(string aranacakkelime)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "Select * From urunler Where ad LIKE '" + aranacakkelime + "%'";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komut);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                baglanti.Close();
                dataGridView1.DataSource = dataTable;



            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu ", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUrunadı.Text = dataGridView1.CurrentRow.Cells["urun_adi"].Value.ToString();
                txtFiyat.Text = dataGridView1.CurrentRow.Cells["fiyat"].Value.ToString();
                txtAdet.Text = dataGridView1.CurrentRow.Cells["adet"].Value.ToString();


            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu ", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    
