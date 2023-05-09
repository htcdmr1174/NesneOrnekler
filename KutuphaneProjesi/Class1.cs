using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace KutuphaneProjesi
{
    class Class1
    {
        readonly string baglantiCumlesi = ConfigurationManager.ConnectionStrings["kutuphaneBaglantiCumlesi"].ConnectionString;


        public MySqlConnection baglan ()
        {
            MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi);
            MySqlConnection.ClearPool(baglanti);
            return baglanti;


        }
    }
}
