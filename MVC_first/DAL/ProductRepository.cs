using MVC_first.Models;

namespace MVC_first.DAL
{
    public class ProductRepository
    {
        public static List<Product> products = new List<Product>
        {
            new Product {Id = 1,Name = "Iphone 7" ,Color = "#FF0000"} ,
            new Product {Id = 2,Name = "Iphone 8" ,Color = "#00FFFF	"} ,
            new Product { Id = 3, Name = "Iphone X", Color = "#8A2BE2" } ,
            new Product { Id = 4, Name = "Iphone XS", Color = "#FF00FF" } ,
            new Product { Id = 5, Name = "Iphone 11", Color = "#FFC0CB" } ,
            new Product { Id = 6, Name = "Iphone 11 Pro", Color = "#C0C0C0" } ,
            new Product { Id = 7, Name = "Iphone 11", Color = "#FFD700" } ,
            new Product { Id = 8, Name = "Iphone 12", Color = "#006400" } ,
            new Product { Id = 9, Name = "Iphone 12 Pro", Color = "#4682B4" } ,
        };

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(int id)
        {
            var entity = products.FirstOrDefault(x => x.Id == id);
            products.Remove(entity);
        }

        public Product GetById(int id)
        {
            var entity = products.FirstOrDefault(x => x.Id == id);
            return entity;
        }

        public void UpdateProduct(Product product)
        {
            var entity = products.FirstOrDefault(x => x.Id == product.Id);
            entity.Name = product.Name;
            entity.Color = product.Color;
        }


    }
}
