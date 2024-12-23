using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSinifProje3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba("27 ABF 235", "OPEL CORSA", 2022, false);

            araba.bakimDurumu = true;
            araba.BilgileriGoster();




        }
    }
}
