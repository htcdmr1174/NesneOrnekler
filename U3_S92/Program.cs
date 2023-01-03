using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S92
{
    class Kisi
    {
        int yas;
        string ad;
        public Kisi()
        {
            yas = 19;
            ad = "selim";
            Console.WriteLine("Yapıcı metot çalıştı");
        }
        public int Yas

        {
            get
            {
                return yas;
            }
        }
        public string Ad
        {
            get
            {
                return ad;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program Başladı");
            Kisi k = new Kisi();
            Console.WriteLine("Adı:{0},Yaşı:{1}", k.Ad, k.Yas);
            Console.WriteLine("program bitti.");
            Console.ReadLine();
        }
    }  }