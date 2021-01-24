using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product  // prop iki tab snippet product = ürün
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } //ürün fiyatı
        public int UnitsInStock { get; set; } // ürün stok adedi

        //CRUD create read update delete  operasyonları

    }
}
