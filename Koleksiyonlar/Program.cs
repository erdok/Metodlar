using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {  // değer type       -       referans type
        //int double str...        class 
        //stock         -          heap
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "engin", "murat", "Halil", "Kerem" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]); // hata veriri

            //isimler = new string[5]; // 5 elemanlı ,heap'te yeni bir referans sayılı boş bir array oluşturur,
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]); // heap'te tanımlanan boş arrayin 5. elemanına ilkeri ekler ve diğerlerini de boş olarak çağırır
            //Console.WriteLine(isimler[0]); // boş bir değer çağırır str nin defaultu boş str dir.



            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
