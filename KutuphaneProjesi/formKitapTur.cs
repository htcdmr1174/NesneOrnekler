using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KutuphaneProjesi
{
    public partial class formKitapTur : Form
    {
        public formKitapTur()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        String komutSatiri;

        private void formKitapTur_Load(object sender, EventArgs e)
        {
            TurleriListele();

        }
        public void TurleriListele()
        {

            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "Select * From kitap_turleri";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridKitapTur.DataSource = dataTable;
                gridKitapTur.Columns["tur_id"].HeaderText = "ID";
                gridKitapTur.Columns["tur_id"].Width = 100;
                gridKitapTur.Columns["tur_id"].HeaderText = "Tür Adı";
                gridKitapTur.Columns["tur_id"].Width = 300;



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
                komut.CommandText = "INSERT INTO kitap_turleri (tur_adi) VALUES (@tur_adi)";
                komut.Parameters.AddWithValue("@tur_adi", txtTurAdi.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                txtTurAdi.Clear();
                MessageBox.Show("işlem başarılı ", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TurleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void gridKitapTur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTurAdi.Text = gridKitapTur.CurrentRow.Cells["tur_adi"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                komut.CommandText = "DELETE FROM kitap_turleri WHERE tur_id = @tur_id";


                komut.Parameters.AddWithValue("@tur_id", gridKitapTur.CurrentRow.Cells["tur_id"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtTurAdi.Clear();
                MessageBox.Show("işlem başarılı ", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TurleriListele();
            }
            catch (Exception ex )
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
                komut.CommandText = "UPDATE kitap_turleri SET tur_id=@tur_id where tur_id=@tur_id";

                komut.Parameters.AddWithValue("tur_id", int.Parse(gridKitapTur.CurrentRow.Cells["tur_id"].Value.ToString()));
                
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtTurAdi.Clear();
                MessageBox.Show("işlem başarılı ", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);

                TurleriListele();
            }
            catch (Exception ex )
            {

                MessageBox .Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}     

