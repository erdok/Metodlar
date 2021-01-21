using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            // urun = herhangi bir değer de olabilir mesela "i"
            // type-safe --tip güvenli ne ile çalışacağını söylemek gerek
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("................");

            }

            Console.WriteLine(".........Metotlar.........");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Deveci armudu", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil", 12, 8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır", 80 , 7);

        }
    }
}
