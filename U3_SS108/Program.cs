using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_SS108
{  
    interface IKütüphane
    {
        void Oku();
    }
     public class Kitap : IKütüphane
    {
        public void Oku()
        {
            Console.WriteLine("KİTAP OKUNDU");

        }
    }
    public class Dergi : IKütüphane
    {
        public void Oku()
        {
            Console.WriteLine("DERGİ OKUNDU ");

        }
    }
    public class Ansiklopedi : IKütüphane
    {
        public void Oku()
        {
            Console.WriteLine("ansiklopedi okunu");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap = new Kitap();
            IKütüphane kitap1 = kitap;
            kitap1.Oku();
            Console.WriteLine("=======");
            Dergi dergi = new Dergi();
            IKütüphane dergi1 = dergi;
            dergi1.Oku();
            Console.WriteLine("=========");
            Ansiklopedi ansiklopedi = new Ansiklopedi();
            Ansiklopedi ansiklopedi1 = ansiklopedi;
            ansiklopedi1.Oku();
            Console.ReadLine();
        }
    }
}
