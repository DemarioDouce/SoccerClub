using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demario_D_301021637.Infrastructure;
using Demario_D_301021637.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demario_D_301021637.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Error() => View();
    }
}