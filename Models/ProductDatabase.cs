using System;
using System.Collections.Generic;
using System.Linq;

namespace WingtipToys.Models
{
    public static class ProductDatabase
    {
        private static List<Category> _categories = new List<Category>
        {
            new Category { CategoryID = 1, CategoryName = "Cars", Description = "Fast and fun miniature cars." },
            new Category { CategoryID = 2, CategoryName = "Planes", Description = "Authentic scale toy aircrafts." },
            new Category { CategoryID = 3, CategoryName = "Trucks", Description = "Heavy duty realistic toy trucks." },
            new Category { CategoryID = 4, CategoryName = "Boats", Description = "Floating high-speed toy boats." },
            new Category { CategoryID = 5, CategoryName = "Rockets", Description = "High flying model rockets." }
        };

        private static List<Product> _products = new List<Product>
        {
            new Product
            {
                ProductID = 1,
                ProductName = "Convertible Car",
                Description = "This convertible car is fast! The engine is powered by a neutrino based battery.",
                ImagePath = "https://images.unsplash.com/photo-1581235720704-06d3acfcb36f?w=500&auto=format&fit=crop&q=60",
                UnitPrice = 22.50,
                CategoryID = 1,
                CategoryName = "Cars"
            },
            new Product
            {
                ProductID = 2,
                ProductName = "Old-time Car",
                Description = "There's nothing old about this classic racer with vintage detailing.",
                ImagePath = "https://images.unsplash.com/photo-1594787318286-3d835c1d207f?w=500&auto=format&fit=crop&q=60",
                UnitPrice = 15.95,
                CategoryID = 1,
                CategoryName = "Cars"
            },
            new Product
            {
                ProductID = 3,
                ProductName = "Fast Plane",
                Description = "Aerodynamic supersonic jet plane with realistic cockpit sound effects.",
                ImagePath = "https://images.unsplash.com/photo-1519074069444-1ba4eae16e61?w=500&auto=format&fit=crop&q=60",
                UnitPrice = 34.95,
                CategoryID = 2,
                CategoryName = "Planes"
            },
            new Product
            {
                ProductID = 4,
                ProductName = "Monster Truck",
                Description = "Giant wheels, rugged all-terrain suspension, ready for high jumps.",
                ImagePath = "https://images.unsplash.com/photo-1596461404969-9ae70f2830c1?w=500&auto=format&fit=crop&q=60",
                UnitPrice = 29.75,
                CategoryID = 3,
                CategoryName = "Trucks"
            },
            new Product
            {
                ProductID = 5,
                ProductName = "Speed Boat",
                Description = "Hydrodynamic speedboat model capable of cruising in water effortlessly.",
                ImagePath = "https://images.unsplash.com/photo-1544551763-46a013bb70d5?w=500&auto=format&fit=crop&q=60",
                UnitPrice = 45.00,
                CategoryID = 4,
                CategoryName = "Boats"
            },
            new Product
            {
                ProductID = 6,
                ProductName = "Apollo Rocket",
                Description = "Multi-stage space exploration rocket with launch stand accessories.",
                ImagePath = "https://images.unsplash.com/photo-1517976487502-5bb1d33190a6?w=500&auto=format&fit=crop&q=60",
                UnitPrice = 122.95,
                CategoryID = 5,
                CategoryName = "Rockets"
            }
        };

        public static List<Category> GetCategories() => _categories;

        public static List<Product> GetProducts(int? categoryId = null)
        {
            if (categoryId.HasValue && categoryId.Value > 0)
            {
                return _products.Where(p => p.CategoryID == categoryId.Value).ToList();
            }
            return _products;
        }

        public static Product GetProductById(int productId)
        {
            return _products.FirstOrDefault(p => p.ProductID == productId);
        }

        public static void AddProduct(Product product)
        {
            product.ProductID = _products.Any() ? _products.Max(p => p.ProductID) + 1 : 1;
            var cat = _categories.FirstOrDefault(c => c.CategoryID == product.CategoryID);
            if (cat != null) product.CategoryName = cat.CategoryName;
            _products.Add(product);
        }
    }
}
