using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Models
{
    public class UpdateProductModel
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public IFormFile Resim { get; set; }
    }
}
