using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        DBMohammadpour db;
        public ProductController(DBMohammadpour _db) => db = _db;

        [HttpPost("[action]")]
        public IActionResult Insert([FromForm] ProductViewModel model) //string name,int price,int count)
        {
            Products p = new Products
            {
                Name = model.name,
                Price = model.price,
                Count = model.count
            };
            if (model.img != null)
            {
                p.Img = new byte[model.img.Length];
                model.img.OpenReadStream().Read(p.Img, 0, p.Img.Length);
                db.Add(p);
                db.SaveChanges();
            }
            return Redirect("/listproducts");
        }
        [HttpGet("[action]")]
        public List<ProductViewModel> getAllProducts()
        {
            //FindByID & Select
            //var tblById = new List<Products>() { db.Find<Products>(1) }.Select(x => new ProductViewModel { }).FirstOrDefault(); 

            return db.Products.Select(x => new ProductViewModel
            {
                Id = x.Id,
                name = x.Name,
                price = x.Price.Value,
                count = x.Count.Value,
                imgBase64 = $"data:image/jpeg;base64,{Convert.ToBase64String(x.Img)}"
            }).ToList();
        }

    }
}