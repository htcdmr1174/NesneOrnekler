using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_SS_106
{
    public abstract class KütüpHane
    {
        public string Kitapadi { get; set; }
        public string dergiadi { get; set; }
        public string ansiklobedi { get; set; }
        public abstract void oku();

    }
    public class Kitap : KütüpHane
    {
        public override void oku()
        {
            Console.WriteLine("kitap okundu ");

        }
    }
    public class Dergi : KütüpHane
    {
        public override void oku()
        {
            Console.WriteLine("dergi okundu");
        }
    }
        public class Ansklobedi: KütüpHane
        {
          public override void oku()
          {
            Console.WriteLine("ansiklobedi okundu");
           }


        }
    class Program
    {
        static void Main(string[] args)
        {
            Kitap k = new Kitap();
            k.Kitapadi = "paronaya";
            Console.Write( "{0} adi",k.Kitapadi );
            k.oku();


            Dergi d = new Dergi();
            d.dergiadi = "çukur";
            Console.Write("{0} ad", d.dergiadi );
            d.oku();

            Ansklobedi a = new Ansklobedi();
            a.ansiklobedi = "temizlikçi";
            Console.Write("{0} adı", a.ansiklobedi);
            a.oku();

            Console.ReadLine();



        }
    }
}
