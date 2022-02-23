using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_OdeV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aşağıdaki Kategorilere Göre Ürün Giriniz.");
            GetCategory();
            Console.WriteLine("Lütfem 10 Ürün Giriniz.");
            List<Product> products = new List<Product>();

            for (int i = 0; i < 3; i++)
            {
                Product product = new Product();
                Console.WriteLine("Ürün Adını Girin");
                product.ProductName = Console.ReadLine();
                Console.WriteLine("ürün Fiyatını Sayisal olarak Giriniz.");
                product.Price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ürüne Yapılacak İndirimi Sayisal olarak girin.");
                product.Discount = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Yukarıda Gördüğünüz Kategoriden seçim yapınız.");
                product.Category = Console.ReadLine();
                products.Add(product);
            }

            foreach (var product in products)
            {
                var discountPrice = product.Price - ((product.Price * product.Discount) / 100);

                Console.WriteLine(product.ProductID + " Ürün Adı :" + product.ProductName + " Ürünün Fiyatı : " + product.Price + " Ürünün İndirimli Fiyatı :" + discountPrice + " Ürünün Kategorisi : " + product.Category);
            }
            Console.ReadLine();

        }
        public static void GetCategory()
        {
            Console.WriteLine("Teknoloji");
            Console.WriteLine("Tekstil");
            Console.WriteLine("Gıda");
        }


    }
}
