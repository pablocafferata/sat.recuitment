using Sat.Recruitment.Api.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Models
{
    public abstract class User: IUser
    {
        protected decimal money = 0;

        public User(Enums.UserTypes userType)
        {
            UserType = userType;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Enums.UserTypes UserType { get; set; }
        public abstract decimal Money { get; set; }
    }
}
