using Microsoft.AspNetCore.Mvc;
using Core_Dersleri.Models;

namespace Core_Dersleri.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public int Index3()
        {
            return 24;
        }
        public string Index4()
        {
            return "merhaba  bugün hava çok soğuk";

        }
        public IActionResult Index5()
        {
            var ktp = new List<Kitap>()
            {
                new Kitap(){ID=1,KitapAd="80 Günde Devri Alem",Yazar="Jules Verne"},
                new Kitap(){ID=2,KitapAd="Bilinmeyen Bir Kadının Mektubu",Yazar="Zweig"},
                new Kitap(){ID=3,KitapAd="Bir Noel Hikayesi",Yazar="Charles Dickens"},
                new Kitap(){ID=4,KitapAd="şeker portakalı",Yazar="vasconceulos"},

            };
            return View(ktp);
        }
        public IActionResult Index6()
        {
            ViewBag.deger1 = "Merhada dersler devam ediyor";
            ViewBag.deger2 = "naber";
            return View();
        }
        public IActionResult Index7()
        {
            return View();
        }
        public IActionResult Index8()
        {
            return View();
        }
        public IActionResult Index9()
        {

            return View();
        }
            


    }
}
