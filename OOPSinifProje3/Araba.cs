using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSinifProje3
{
    public class Araba
    {
        public string plaka;
        public string model;
        public int yil;
        public bool bakimDurumu;


        public Araba() { }

        public Araba(string plaka, string model, int yil, bool bakimDurumu)
        {
            this.plaka = plaka;
            this.model = model;
            this.yil = yil;
            this.bakimDurumu = false;
        }

        public bool BakimYap()
        {
            
            return true; 
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("Plaka {0} - Model {1} - Yil {2} - BakimDurumu :  {3} ", plaka, model, yil, bakimDurumu);
        }
    }

    
}
