using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    internal class ProductManager
    {
        //Add metotunun içine parametreleri teker teker girmektense product sınıfı oluşturup productı verdik
        //Bu encapsulation'dır.
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
    }
}
