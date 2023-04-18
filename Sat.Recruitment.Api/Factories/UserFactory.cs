using Sat.Recruitment.Api.Factories.Interfaces;
using Sat.Recruitment.Api.Models;
using Sat.Recruitment.Api.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Factories
{
    public class UserFactory: IUserFactory
    {
        public UserFactory() { }
        public IUser GetUser(Enums.UserTypes userType)
        {
            IUser user = userType switch
            {
                Enums.UserTypes.Normal => new NormalUser(),
                Enums.UserTypes.Super => new SuperUser(),
                Enums.UserTypes.Premium => new PremiumUser(),
                _ => throw new Exception("Wrong user type"),
            };

            return user;
        }
    }
}
