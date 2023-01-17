using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S109
{

    interface ISekil
    {
        void Ciz();
    }
    class Kare : ISekil
    {
        public void Ciz()
        {
            Console.WriteLine("kare cizildi");
        }
    }
    class Daire : ISekil
    {
        public void Ciz()
        {
            Console.WriteLine("daire cizildi");
        }
    }
    class Ücgen : ISekil
    {
        public void Ciz()
        {
            Console.WriteLine("üçgen cizildi");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<ISekil> sekiller = new List<ISekil>
            {
                new Daire(),
                new Kare(),
                new Ücgen()

            };
            foreach (var sekil in sekiller) 
            {
               sekil.Ciz();
            }
            Console.ReadLine();

        }
    }
}
