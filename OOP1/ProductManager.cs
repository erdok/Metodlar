using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager  // ürünle ilgili operasyonları barındırır
    {
        public void Add(Product product)  // METODUN NASIL ÇAĞRILACAĞININ ANLATIĞI YER
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

        
    }

}
