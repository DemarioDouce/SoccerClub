using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demario_D_301021637.Models
{
    public class Clubs
    {

        [Key]
        public int ClubID { get; set; }
        public string ClubName { get; set; }
        public string ClubManager { get; set; }
        public string ClubDetails { get; set; }
        public string createdBy { get; set; }

    }

}
