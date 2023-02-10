using Microsoft.AspNetCore.Mvc;
using MVC_first.DAL;
using MVC_first.Models;

namespace MVC_first.Controllers
{
    public class ProductsController : Controller
    {
        ProductRepository productRepository = new();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Product> products = new List<Product>();
            products = ProductRepository.products;
            return View(products);
        }
        public IActionResult Delete(int id)
        {
            productRepository.RemoveProduct(id);
            return RedirectToAction("List");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            productRepository.AddProduct(new Product { Id = ProductRepository.products[ProductRepository.products.Count - 1].Id + 1, Name = product.Name, Color = product.Color });
            return RedirectToAction("List");
        }

        public IActionResult Detail(int id)
        {
            var product = productRepository.GetById(id);
            return View(product);
        }

        public IActionResult Update(int id)
        {
            var product = productRepository.GetById(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            productRepository.UpdateProduct(product);
            return RedirectToAction("List");
        }


        public bool CheckName(string name)
        {
            if (name.Length < 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
