using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Sat.Recruitment.Api.Controllers;
using Sat.Recruitment.Api.DTOs;
using Sat.Recruitment.Api.Factories;
using Sat.Recruitment.Api.Models;
using Sat.Recruitment.Api.Repositories;
using Sat.Recruitment.Api.Services;
using Sat.Recruitment.Api.Utils;
using Xunit;

namespace Sat.Recruitment.Test
{
    [CollectionDefinition("Tests", DisableParallelization = true)]
    public class UnitTest1
    {
        [Fact]
        public void Post_CreatesNewUser()
        {
            // Arrange
            var controller = new UsersController(new UserService(new UserFactory(), new UserRepository()));

            var user = new UserDTO { Name ="Pablo", Address="Zapeti 120", Email="pablo@gmail.com", Money=120, Phone="+549458741254", UserType = Enums.UserTypes.Normal };

            // Act
            var result = controller.CreateUser(user);

            var response = (result as CreatedResult).Value as UserResponse;

            Assert.True(response.IsSuccess);
            Assert.Equal("User Created", response.Message);
        }

        [Fact]
        public void Post_CreatesDuplicatedUser()
        {
            // Arrange
            var controller = new UsersController(new UserService(new UserFactory(), new UserRepository()));

            var user = new UserDTO { Name = "Juan", Address = "Peru 2464", Email = "Juan@marmol.com", Money = 1234, Phone = "+5491154762312", UserType = Enums.UserTypes.Normal };

            // Act
            var result = controller.CreateUser(user);

            var response = (result as BadRequestObjectResult).Value as UserResponse;

            Assert.False(response.IsSuccess);
            Assert.Equal("User Duplicated", response.Message);
        }
    }
}
