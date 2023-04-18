using Sat.Recruitment.Api.Models;
using Sat.Recruitment.Api.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Factories.Interfaces
{
    public interface IUserFactory
    {
        IUser GetUser(Enums.UserTypes userType);
    }
}
