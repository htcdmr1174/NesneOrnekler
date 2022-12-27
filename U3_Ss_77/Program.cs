using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_Ss_77
{
    class Program
    {
        static void Main(string[] args)
        {
            Daire daire = new Daire(4);
            Console.WriteLine("DAİRELERİN alanı= " + daire.AlanHesapla());
            Console.WriteLine("DAİRENİN çevresi =" + daire.CevreHesapla());
            Console.ReadLine();


        }
    }
    class Daire 
    {
        private double r;
        public Daire(double r)
        {
            this.r = r ;

        }
         public double CevreHesapla()
        {
            return (2 + Math.PI + r);
        }

         public double AlanHesapla()
        {
            return (2 * Math.PI * r);
        }


    }



}

