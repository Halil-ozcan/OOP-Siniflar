using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSinifProje2
{
    public class Kitap
    {
        string KitapAdi;
        string Yazar;
        string sayfaSayisi;


        public Kitap(string kitapAdi, string yazar, string sayfaSayisi)
        {
            KitapAdi = kitapAdi;
            Yazar = yazar;
            this.sayfaSayisi = sayfaSayisi;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("Kitabin Adi {0} - Yazar {1} - SayfaSayisi{2}", KitapAdi, Yazar, sayfaSayisi);
        }
    }
}
