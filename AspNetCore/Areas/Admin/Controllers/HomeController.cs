using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Contexts;
using AspNetCore.Interfaces;
using AspNetCore.Models;
using AspNetCore.Entities;
using System.IO;

namespace AspNetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IUrunRepository _urunRepository;
        public HomeController(IUrunRepository urunRepository)
        {
            _urunRepository = urunRepository;

        }
        public IActionResult Index()
        {
            return View(_urunRepository.GetAll());
        }
        public IActionResult Ekle()
        {
            return View(new AddProduct());
        }
        [HttpPost]
        public IActionResult Ekle(AddProduct model)
        {
            if (ModelState.IsValid)
            {
                Urun urun = new Urun();

                if (model.Resim !=null)
                {
                    var uzanti = Path.GetExtension(model.Resim.FileName);
                    var yeniResimAd = Guid.NewGuid() + uzanti;
                    var yuklenecekYer = Path.Combine(Directory.GetCurrentDirectory(),@"/wwwroot/img/" + yeniResimAd);
   
                    var stream = new FileStream(yuklenecekYer, FileMode.Create);
                    model.Resim.CopyTo(stream);

                    urun.Resim = yeniResimAd;
                }
                urun.Ad = model.Ad;
                urun.Fiyat = model.Fiyat;

                _urunRepository.Add(urun);//GENERİC REPODAN GELDİ
                return RedirectToAction("Index", "Home", new {area="Admin" });

            }
            return View(model);
        }
      
    }
}
