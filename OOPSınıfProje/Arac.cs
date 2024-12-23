using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSınıfProje
{
    public class Arac
    {
        public string Marka;
        public string Model;
        public int ModelYil;
        public decimal Km;
        public string YakitTipi;
        public int VitesTipi;
        public decimal AlisFiyati;
        public decimal SatisFiyati;
        public decimal MaxİndirimTutar;
        public decimal Fiyat;
        

        public Arac() { }

        public Arac(string _marka, string _model)
        {
            Marka = _marka;
            Model = _model;
           
           
        }

        public Arac(string _marka, string _model, int _modelYil)
        {
            Marka = _marka;
            Model = _model;
            ModelYil = _modelYil;
        }

        public Arac(string _marka, string _model, int _modelYil, decimal _km)
        {
            Marka = _marka;
            Model = _model;
            ModelYil = _modelYil;
            Km = _km;
        }


        public void BilgiGoster()
        {
            Console.WriteLine("Marka {0} - Model {1} - ModelYil{2}", Marka, Model, ModelYil); 
        }

        public void fiyatAta(decimal _fiyat)
        {
            decimal fiyatHesap = SatisFiyati - MaxİndirimTutar;
            if(_fiyat<fiyatHesap)
            {
                Console.WriteLine("Geçersiz Fiyat Girişi");
            }
            else
            {
                this.Fiyat = _fiyat;
                Console.WriteLine("Fiyat Bilgisi Güncellendi");
            }
        }
    }
}
