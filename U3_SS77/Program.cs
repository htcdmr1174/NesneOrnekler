using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_SS77
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen(8, 10);

            Console.WriteLine("dikdörtgenin alanı:" + dikdortgen.AlanHesapla()); ;
            Console.WriteLine("diktörtgenin çevresi: " + dikdortgen.CevreHesapla());
            Console.ReadLine();
        }
    }
    class Dikdortgen
    {
        private int a, b;

        public Dikdortgen (int a, int b)
        {
            this.a = a;
            this.b = b;

        }

        public int AlanHesapla()
        {
            return a * b;
        }
          
        public  int CevreHesapla()
        {
            return 2 * (a + b);
        }






    }






}
