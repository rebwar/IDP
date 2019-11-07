using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APP.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace APP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            var result = client.GetStringAsync("http://localhost:1919/api/values").Result;
            var contact = JsonConvert.DeserializeObject<List<Contact>>(result);
            return View(contact);
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
