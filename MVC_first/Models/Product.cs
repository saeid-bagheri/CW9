using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MVC_first.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "name is ...")]
        [Remote(controller:"Products", action: "CheckName", ErrorMessage ="name is invalid")]
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
