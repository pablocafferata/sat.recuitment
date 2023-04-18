using Sat.Recruitment.Api.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Models
{
    public class NormalUser : User
    {
        public NormalUser() : base(Enums.UserTypes.Normal)
        {
        }

        public override decimal Money
        {
            get
            {
                decimal porcentage = money switch
                {
                    > 100 => Convert.ToDecimal(0.12),
                    > 10 => Convert.ToDecimal(0.08),
                    _ => 1,
                };

                return money * porcentage;
            }
            set
            {
                money = value;
            }
        }
    }
}
