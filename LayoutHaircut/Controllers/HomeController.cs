using LayoutHaircut.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LayoutHaircut.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            List<Berber> berberler = new List<Berber>()
            {
                new Berber()
                {
                    AdSoyad = "Galip Yıldız",
                    ResimYolu = "/img/team-1.jpg",
                    Unvan = "Barber Shop Operator"
                },
                new Berber()
                {
                    AdSoyad = "Hüseyin Yılmaz",
                    ResimYolu = "/img/team-2.jpg",
                    Unvan = "Cosmetologist"
                },
                new Berber()
                {
                    AdSoyad = "Yusuf Badem",
                    ResimYolu = "/img/team-3.jpg",
                    Unvan = "Salon Manager"
                },
                new Berber()
                {
                    AdSoyad = "Zeki Berk Tonguç",
                    ResimYolu = "/img/team-4.jpg",
                    Unvan = "Hair Cutter"
                },
                new Berber()
                {
                    AdSoyad = "Berna Dereağzı",
                    ResimYolu = "https://i.pinimg.com/564x/db/34/0f/db340f3f5daf011feb121135fb5192c7.jpg",
                    Unvan = "Makeup Artist"
                }
            }; 
            return View(berberler);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
