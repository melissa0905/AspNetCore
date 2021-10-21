 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage="Kullanici Adi boş geçilemez")]
        public string KullaniciAdi { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez")]
        public string Sifre { get; set; }
        public bool BeniHatirla { get; set; }
    }
}
