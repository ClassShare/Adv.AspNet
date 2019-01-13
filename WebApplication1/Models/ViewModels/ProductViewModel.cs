using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int count { get; set; }
        public int price { get; set; }
        public IFormFile img { get; set; }
        public string imgBase64 { get; set; }
    }
}
