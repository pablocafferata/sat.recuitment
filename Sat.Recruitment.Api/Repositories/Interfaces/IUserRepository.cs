using Sat.Recruitment.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Repositories.Interfaces
{
    public interface IUserRepository
    {
        bool IsUserDuplicated(IUser user);
    }
}
