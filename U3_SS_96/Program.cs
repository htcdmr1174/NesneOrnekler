using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_SS_96
{
    class TrueFalse
    {
        public bool dogruyanliş(int sayi1)
        {
            if (sayi1 % 2 == 0)
                return false;
            else
                return true;
            
        }
    }
     class Program
      {
       static void Main(string[] args)
         {
            TrueFalse tr = new TrueFalse();
            Console.WriteLine("sayı:{0}", tr.dogruyanliş(11));
            Console.ReadLine();
            }

        }
    
}