using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demario_D_301021637.Models.ViewModels
{
    public class LoginModel
    {

        public string Name { get; set; }
        public string Password { get; set; }
        public string ReturnUrl { get; set; } = "/";
    }
}
