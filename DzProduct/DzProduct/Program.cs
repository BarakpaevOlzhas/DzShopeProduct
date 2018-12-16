using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegetables = new Category
            {
                Name = "Овощи"
            };
            var fruits = new Category
            {
                Name = "Фрукты"
            };
            var milk = new Category
            {
                Name = "Молочные"
            };

            using (ProductShop sqlContext = new ProductShop())
            {
                sqlContext.Category.Add(vegetables);
                sqlContext.Category.Add(fruits);
                sqlContext.Category.Add(milk);

                sqlContext.Products.Add(
                    new Product
                    {
                        Name = "Огурец",
                        Price = 20,
                        IdCategory = vegetables
                    }               
                    );

                sqlContext.Products.Add(
                    new Product
                    {
                        Name = "Яблоко",
                        Price = 50,
                        IdCategory = fruits
                    }
                    );

                sqlContext.Products.Add(
                    new Product
                    {
                        Name = "Молоко",
                        Price = 300,
                        IdCategory = milk
                    }
                    );

                sqlContext.SaveChanges();
            }
        }
    }
}
