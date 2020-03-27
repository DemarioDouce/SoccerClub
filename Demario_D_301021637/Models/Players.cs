using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demario_D_301021637.Models
{
    public class Players
    {
        [Key]
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public string PlayerClub { get; set; }
        public string PlayerPosition { get; set; }

    }
}
