using Sat.Recruitment.Api.DTOs;
using Sat.Recruitment.Api.Exceptions;
using Sat.Recruitment.Api.Extensions;
using Sat.Recruitment.Api.Factories;
using Sat.Recruitment.Api.Factories.Interfaces;
using Sat.Recruitment.Api.Repositories.Interfaces;
using Sat.Recruitment.Api.Services.Interfaces;

namespace Sat.Recruitment.Api.Services
{
    public class UserService : IUserService
    {
        private readonly IUserFactory userFactory;
        private readonly IUserRepository userRepository;

        public UserService(IUserFactory uf, IUserRepository ur) {
            userFactory = uf;
            userRepository = ur;
        }

        public void CreateUser(UserDTO dto)
        {
            var user = userFactory.GetUser(dto.UserType);

            user.Address = dto.Address;
            user.Email = dto.Email.NormalizeEmail(); 
            user.Name = dto.Name;
            user.Money = dto.Money;

            if (userRepository.IsUserDuplicated(user))
            {
                throw new DuplicatedException();
            }
        }
    }
}
