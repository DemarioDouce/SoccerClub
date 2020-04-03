using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demario_D_301021637.Infrastructure;
using Demario_D_301021637.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demario_D_301021637.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService uptime;
        public HomeController(UptimeService up) => uptime = up;

        public ViewResult Index()
        => View(new Dictionary<string, string>
        {
            ["Uptime"] = $"{uptime.Uptime} ms"
        });

        public ViewResult Features()
        {
            return View();
        }

    }
}