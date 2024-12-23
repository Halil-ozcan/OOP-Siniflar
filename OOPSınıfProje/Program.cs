using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSınıfProje
{
   public class Program
    {
        static void Main(string[] args)
        {

            Arac arac = new Arac("Opel", "Corsa",2010, 56000);

            arac.AlisFiyati = 45000;
            arac.AlisFiyati = 60000;
            arac.MaxİndirimTutar = 10000;

            arac.fiyatAta(50000);
            arac.BilgiGoster();

           

        }
    }
}
