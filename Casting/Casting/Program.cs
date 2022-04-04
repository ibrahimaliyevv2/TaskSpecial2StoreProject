using System;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            DiscountedProduct discountedProduct1 = new DiscountedProduct {
                Name = "Notebook HP",
                Price = 50,
                DiscountPercent=10
            };
            store.AddProduct(discountedProduct1);

            DiscountedProduct discountedProduct2 = new DiscountedProduct
            {
                Name = "Notebook LG",
                Price = 80,
                DiscountPercent = 20
            };
            store.AddProduct(discountedProduct2);

            DiscountedProduct discountedProduct3 = new DiscountedProduct
            {
                Name = "Notebook Apple",
                Price = 100,
                DiscountPercent = 30
            };
            store.AddProduct(discountedProduct3);

            Console.WriteLine(store.GetAvgDiscountAmount());
        }
    }
}
