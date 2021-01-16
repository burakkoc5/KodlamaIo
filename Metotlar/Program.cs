using System;

namespace Metotlar
    //Do not repeat yourself - DRY - Clean Code - Best Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string urunAdi = "Elma";
            double fiyat = 15;
            string aciklama = "Amasya Elması";
            */

            Urun urun1 = new Urun();
            urun1.Ad = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Ad = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Urun adi : " + urun.Ad);
                Console.WriteLine("Urun fiyatı : " + urun.Fiyat);
                Console.WriteLine("Urun aciklama : " + urun.Aciklama );
                Console.WriteLine("----------------------------------");
                
            }


            
            Console.WriteLine("----------------Metotlar-------------------");
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);//sayfa1
            sepetManager.Ekle(urun2);//sayfa2


            sepetManager.Ekle2("Armut", "Yeşil Armut" , 12,10);
            sepetManager.Ekle2("Elma" , "Yeşil Elma" , 12,8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,5);







        }

        










    }
}
