using AspNetCore.Interfaces;
using AspNetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Entities;
using Microsoft.AspNetCore.Identity;
namespace AspNetCore.Controllers
{

    public class HomeController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IUrunRepository _urunRepository;
        public HomeController(IUrunRepository urunRepository,SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
            _urunRepository = urunRepository;
        }
        public IActionResult Index()
        {
            return View(_urunRepository.GetAll());
        }
        public IActionResult UrunDetay (int id)
        {
            return View(_urunRepository.GetAllId(id));
        }
        
        public IActionResult Login()
        {
            return View(new UserLoginModel());
        }
        [HttpPost]
        public IActionResult Login(UserLoginModel model)
        {
            if(ModelState.IsValid)
            {
               var signInResult =_signInManager.PasswordSignInAsync(model.KullaniciAdi,model.Sifre,model.BeniHatirla,false).Result;
                if (signInResult.Succeeded)
                {
                    return RedirectToAction("Index", "Home", new {area="Admin"});
                }
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
            }
            
            return View(new UserLoginModel());
        }

    }
}
