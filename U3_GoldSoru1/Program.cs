using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_GoldSoru1
{ 
    interface IHesap
    {
        void Ciz();
        double  AlanHesapla(int a, int b = 1, double pi = 3.14);
       double  CevreHesapla(int a, int b = 1,double pi =3.14);
     }
    class Kare : IHesap 
    {
        public double AlanHesapla(int a, int b = 1, double pi = 3.14)
        {
            return a * a;
        }
       public  double CevreHesapla(int a, int b = 1, double pi = 3.14)
        {
            return a * 4;
        }
        public void Ciz()
        {
            Console.WriteLine("kare hesapla ");
        }
    }
    class Daire : IHesap 
    {
        public double AlanHesapla(int a, int b = 1, double pi = 3.14)
        {
            return 2*Math .PI*Math.Pow (a,2) ;
        }
        public double CevreHesapla(int a, int b = 1, double pi = 3.14)
        {
            return 2*Math .PI *a;
        }
        public void Ciz()
        {
            Console.WriteLine("daire cizildi");
        }
    }
    class Ucgen : IHesap 
    {
        public double AlanHesapla(int a, int b = 1, double pi = 3.14)
        {
            return a *b /2;
        }
        public double CevreHesapla(int a, int b = 1, double pi = 3.14)
        {
            return a*4;
        }
        public void Ciz()
        {
            Console.WriteLine("ücgen cizildi");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Kare k = new Kare();
            Daire d = new Daire();
            Ucgen u = new Ucgen();
            IHesap hesaplaKare = k;

            Console.WriteLine("kare alanhesaplama : {0}", hesaplaKare.AlanHesapla(3));
            Console.WriteLine("kare alanhesaplama : {0}", hesaplaKare.CevreHesapla(5));
            IHesap hesaplaDaire = d;
            Console.WriteLine("========");
            Console.WriteLine("kare alanhesaplama : {0}", hesaplaDaire.AlanHesapla(4));
            Console.WriteLine("kare alanhesaplama : {0}", hesaplaKare.CevreHesapla(10));
            Console.WriteLine("========");
            IHesap hesapUcgen = u;
            Console.WriteLine("ucgen alan hesaplama : {0}", hesapUcgen.AlanHesapla(3, 4));
            Console.WriteLine("ucgen alan hesaplama : {0}", hesapUcgen.CevreHesapla(3));
            Console.ReadLine();
        }
    }
}