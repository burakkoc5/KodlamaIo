using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    //Manager vs gibi class lar operasyon tutar
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler, " + urun.Ad+" sepete eklendi");
        }
        public void Ekle2(string isim , string aciklama , int fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler, " +isim + " sepete eklendi");
        }

    }
}
