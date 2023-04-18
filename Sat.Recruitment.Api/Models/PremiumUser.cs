using Sat.Recruitment.Api.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Models
{
    public class PremiumUser : User
    {
        public PremiumUser() : base(Enums.UserTypes.Premium)
        {
        }
        public override decimal Money
        {
            get
            {
                return money * 3;
            }
            set
            {
                money = value;
            }
        }
    }
}
