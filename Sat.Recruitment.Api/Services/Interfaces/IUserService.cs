using Sat.Recruitment.Api.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sat.Recruitment.Api.Services.Interfaces
{
    public interface IUserService
    {
        void CreateUser(UserDTO dto);
    }
}
