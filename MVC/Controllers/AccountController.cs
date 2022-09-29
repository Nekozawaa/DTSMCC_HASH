using DTSMCC_Exam2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class AccountController : Controller
    {
        HttpClient HttpClient;
        string address;

        public AccountController()
        {
            this.address = "https://localhost:50911/";
            HttpClient = new HttpClient
            {
                BaseAddress = new Uri(address)
            };
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Login login)
        {
            StringContent content = new StringContent(JsonConvert.SerializeObject(login),
                Encoding.UTF8, "application/json");
            var result = HttpClient.PostAsync(address, content).Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
