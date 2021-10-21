using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Entities
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int UrunId { get; set; }
        public Urun Urun { get; set; }
    }
}
