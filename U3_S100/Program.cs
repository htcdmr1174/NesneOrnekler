using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S100
{
    class OkulPersonel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

    }
    class Ogretmen : OkulPersonel
    {
        public string Brans { get; set; }

    }

    class program
    {
        static void Main(string[] args)
        {
            OkulPersonel per = new OkulPersonel();
            Ogretmen ogrt = new Ogretmen();

            ogrt.Ad = "serkan";
            ogrt.Soyad = "aydın";
            ogrt.Brans = "Bilişim";
            Console.WriteLine("ögretmen sınıfından turetilen  {0} {1} {2}", ogrt.Ad, ogrt.Soyad, ogrt.Brans);


            per.Ad = "ramazan";
            per.Soyad ="güneş";
            Console.WriteLine("OkulPersonoli sınavda türetilen {0} {1}", per.Ad, per.Soyad);
            Console.ReadLine();

        }

    }
}
