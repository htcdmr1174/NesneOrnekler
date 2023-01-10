using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S105
{
    public abstract class MotorluArac
    {
        public int MotorHacmi { get; set; }
        public int ModelYili { get; set; }

        public abstract void Calıs();
        public abstract void Dur();

    }
    public class Otomobil : MotorluArac
    {
        public bool OtomatikVites { get; set; }
        public override void Calıs()
        {
            Console.WriteLine("otomobil çalıştı ");

        }
        public override void Dur()
        {
            Console.WriteLine("otomobil durdu ");
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil oto = new Otomobil
            {
                ModelYili = 2020,
                MotorHacmi = 1600,
                OtomatikVites = true
            };
            oto.Calıs();
            oto.Dur();
            Console.ReadLine();



        }
    }

}
