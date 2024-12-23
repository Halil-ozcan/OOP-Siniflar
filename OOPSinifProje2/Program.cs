using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSinifProje2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap = new Kitap("Martin Eden", "Jack London", "250");
            Kitap kitap1 = new Kitap("1984", "George Orwell", "400");
            Kitap kitap2 = new Kitap("Uğultulu Tepeler", "Emily Bronte", "320");
            
            kitap.BilgileriGoster();
            kitap1.BilgileriGoster();
            kitap2.BilgileriGoster();
        }
    }
}
