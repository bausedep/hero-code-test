using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Models
{
    public class SignUpModel
    {
        public Guid? Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string First { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string Last { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mobile Phone is required")]
        [Phone]
        public string Mobile { get; set; }

        [Range(1, 120)]
        public int Age { get; set; }

    }
}
