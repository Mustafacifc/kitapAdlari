using kitapAdlari.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace kitapAdlari.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            KitapModel kitap = new KitapModel();
            kitap.KitapId = 1;
            kitap.KitapAdi = "Cemil Reloaded";
            kitap.sayfaSayisi = 1233;
            kitap.yazari = " Reha Çamuroğlu";
            kitap.turu = "Roman";


            KitapModel kitap1 = new KitapModel();
            kitap.KitapId = 2;
            kitap.KitapAdi = "Mustafa Çiftçi Hayatı";
            kitap.sayfaSayisi = 1233;
            kitap.yazari = "Mustafa Çiftçi";
            kitap.turu = "Roman";
            ViewBag.Kitaplar = kitap;
            ViewBag.Kitaplar1 = kitap1;

            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}