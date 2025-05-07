using eCommerce.Models;
using System;
using System.Linq;

namespace eCommerce.Data
{
    public class DbInitializer
    {
        public static void Initialize(ProductContext context)
        {
            // Check if the database has been created
            context.Database.EnsureCreated();
            // Check if there are any products in the database
            if (context.Products.Any())
            {
                return; // Database has been seeded
            }
            // Seed the database with initial data
            var products = new Product[]
            {
                new Product () { Id = "1", Name = "Bottle", Price = 1000.0, Photo = "bottle.jpg" },
                new Product () { Id = "2", Name = "Headset", Price = 5020.0, Photo = "headset.jpg" },
                new Product () { Id = "3", Name = "Perfume", Price = 1700.0, Photo = "perfume.jpg" },
                new Product () { Id = "4", Name = "Spectacule", Price = 2000.0, Photo = "spec.jpg" },
                new Product () { Id = "5", Name = "Watch", Price = 5000.0, Photo = "watches.jpg" },

            };

            foreach (Product p in products)
            {
                context.Products.Add(p);
            }

            context.SaveChanges();
        }
    }
}
