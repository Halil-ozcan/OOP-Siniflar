using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sınıflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            musteri.TCkimlikNumara = "12345678901";
            musteri.ad = "Halil";
            musteri.soyad = "Özcan";
            musteri.cinsiyet = "Erkek";
        }
    }
}
