using System;
using System.Collections.Generic;
using System.Text;

namespace Casting
{
    internal class Store
    {
        Product[] _products = new Product[0];
        public Product[] Products { get => _products; }
        public void AddProduct(Product product)
        {
            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;
        }

        public double GetAvgDiscountAmount()
        {
            int count = 0;
            double sum = 0;

            foreach (var pr in _products)
            {
                if(pr is DiscountedProduct)
                {
                    DiscountedProduct disPr = pr as DiscountedProduct;
                    count++;
                    sum += disPr.Price * (100 - disPr.DiscountPercent) / 100;
                }
            }

            return sum / count;
        }
    }
}
