using Sat.Recruitment.Api.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.DTOs
{
    public class UserDTO
    {
        [Required(ErrorMessage = "The name is required")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "The email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The phone is required")]
        public string Phone { get; set; }

        public Enums.UserTypes UserType { get; set; }
        public decimal Money { get; set; }
    }
}
