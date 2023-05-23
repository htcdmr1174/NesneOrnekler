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
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri , baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                comboKitapTur.DataSource = dataTable;
                comboKitapTur.ValueMember = "tur_id";
                comboKitapTur.DisplayMember = "tur_id";

            }
            catch (Exception ex )
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
                 
                gridKitap.Columns["kitap_id"].
            }
            catch (Exception)
            {

                throw;
            }



        }
        



    }
}
