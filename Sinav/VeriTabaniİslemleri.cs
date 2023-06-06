using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace Sinav
{
    class VeriTabaniİslemleri
    {
        class VeriTabaniIslemleri
        {
            string baglantiCumlesi = ConfigurationManager.ConnectionStrings["kutuphaneBaglantiCumlesi"].ConnectionString;


            public MySqlConnection baglan()
            {
                MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi);
                MySqlConnection.ClearPool(baglanti);
                return baglanti;

            }
        }
 }   }