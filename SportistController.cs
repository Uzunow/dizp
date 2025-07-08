using ginerweb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ginerweb.Controllers
{
    public class SportistController
    {
        public IActionResult Index()
        {
            var sportist = new Sportist
            {
                Id = 1,
                Ime = "Lionel Messi",
                Otbor = "Inter Miami",
                Poziciya = "Нападател",
                SnimkaUrl = "/images/messi-banner.jpg"
            };

            return View(sportist);
        }

        private IActionResult View(Sportist sportist)
        {
            throw new NotImplementedException();
        }
    }

}

