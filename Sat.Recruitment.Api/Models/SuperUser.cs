using Sat.Recruitment.Api.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Models
{
    public class SuperUser : User
    {
        public SuperUser() : base(Enums.UserTypes.Super)
        {
        }
        public override decimal Money
        {
            get
            {
                decimal porcentage = money > 100 ? Convert.ToDecimal(0.20) : 1;

                return money * porcentage;
            }
            set
            {
                money = value;
            }
        }
    }
}
