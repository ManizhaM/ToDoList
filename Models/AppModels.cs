using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace todolistapp.Models
{
    public class Users
    {
        [Required]
        public int id { get; set; }

        [StringLength(20, MinimumLength = 3)]
        public string name { get; set; }

        [Phone]
        public string phone { get; set; }
        [Required]
        public string login { get; set; }
        [Required]
        public string password { get; set; }
    }

    public class Tasks
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime deadline { get; set; }
        public string priority { get; set; }
        public int userid { get; set; }
    }
}
