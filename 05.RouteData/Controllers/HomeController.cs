
using Microsoft.AspNetCore.Mvc;

namespace _05.RouteData.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            var routeData = RouteData.Values;
            //Route'yi oldu�u gibi alabilmemizi sa�lar. Dictionary olarak getirir yani key,value tarz�nda gelir. Program.cs i�erisinde yazd���m�z Route'ye g�re key ve value'ler olu�ur. Controller, Action ve id bir keydir. Burada Controller key'ine kar��l�k Home bir valuedir.

            //�zet ge�ersek bir Route'nin Controller,Action ve route olarak g�nderilen bilgisinin(id vb.) elde edilmesini sa�lar.

            string? controller = routeData["controller"]?.ToString();
            string? controller2 = RouteData.Values["controller"]?.ToString();

            string? action = routeData["action"]?.ToString();
            string? action2 = RouteData.Values["action"]?.ToString();

            int id, id2 = 0;
            if (routeData["id"] is not null)
            {
                id = int.Parse(routeData["id"].ToString());
                id2 = int.Parse(RouteData.Values["id"].ToString());
            }
                
            return View();
        }

    }
}
