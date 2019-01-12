using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Insert(Product model) //string name,int price,int count)
        {
            return View();
        }
    }
}