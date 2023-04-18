using Sat.Recruitment.Api.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Models
{
    public interface IUser
    {
        string Name { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string Phone { get; set; }
        Enums.UserTypes UserType { get; set; }
        decimal Money { get; set; }
    }
}
