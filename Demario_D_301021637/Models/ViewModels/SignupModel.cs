using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demario_D_301021637.Models
{
    public class SignupModel
    {

        public int UserID { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter Confirm password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirm password should be matched")]
        public string ConfirmPassword { get; set; }

        public List<Clubs> associatedClubs;

        public Boolean isAdmin;

        [Required(ErrorMessage = "Please enter Email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        public string ReturnUrl { get; set; } = "/";
    }
}
