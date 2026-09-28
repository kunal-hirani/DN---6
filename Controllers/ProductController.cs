using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        // In-memory static list to store products during application runtime
        private static List<Product> _products = new List<Product>()
        {
            new Product
            {
                ProductId = 1,
                ProductName = "Laptop",
                Description = "High-performance laptop suitable for coding, gaming, and multitasking.",
                Price = 850.00m,
                Category = "Electronics",
                StockQuantity = 15
            },
            new Product
            {
                ProductId = 2,
                ProductName = "Smartphone",
                Description = "5G Smartphone featuring crisp OLED display and all-day battery life.",
                Price = 599.99m,
                Category = "Electronics",
                StockQuantity = 25
            },
            new Product
            {
                ProductId = 3,
                ProductName = "Headphones",
                Description = "Wireless noise-cancelling over-ear headphones with premium studio sound.",
                Price = 120.50m,
                Category = "Audio",
                StockQuantity = 40
            },
            new Product
            {
                ProductId = 4,
                ProductName = "Keyboard",
                Description = "Mechanical RGB gaming keyboard with tactile blue switches.",
                Price = 75.00m,
                Category = "Accessories",
                StockQuantity = 30
            },
            new Product
            {
                ProductId = 5,
                ProductName = "Mouse",
                Description = "Ergonomic wireless optical mouse with adjustable DPI settings.",
                Price = 35.00m,
                Category = "Accessories",
                StockQuantity = 50
            }
        };

        // 1. GET: /Product/Index
        // Displays all products in the catalog
        public IActionResult Index()
        {
            return View(_products);
        }

        // 2. GET: /Product/Details/1
        // Displays complete details of a specific product
        public IActionResult Details(int id)
        {
            var product = _products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // 3. GET: /Product/Create
        // Displays form to create a new product
        public IActionResult Create()
        {
            return View();
        }

        // 4. POST: /Product/Create
        // Processes form submission and adds new product
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                int nextId = _products.Any() ? _products.Max(p => p.ProductId) + 1 : 1;
                product.ProductId = nextId;
                _products.Add(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // 5. GET: /Product/Edit/1
        // Displays edit form for an existing product
        public IActionResult Edit(int id)
        {
            var product = _products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // 6. POST: /Product/Edit
        // Updates product in the static list
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                var existingProduct = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
                if (existingProduct != null)
                {
                    existingProduct.ProductName = product.ProductName;
                    existingProduct.Description = product.Description;
                    existingProduct.Price = product.Price;
                    existingProduct.Category = product.Category;
                    existingProduct.StockQuantity = product.StockQuantity;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // 7. GET: /Product/Delete/1
        // Displays delete confirmation page
        public IActionResult Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // 8. POST: /Product/Delete/1
        // Deletes the confirmed product
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                _products.Remove(product);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
