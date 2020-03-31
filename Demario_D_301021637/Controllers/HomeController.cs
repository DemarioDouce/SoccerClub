using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demario_D_301021637.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demario_D_301021637.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Features()
        {
            return View();
        }

    }
}