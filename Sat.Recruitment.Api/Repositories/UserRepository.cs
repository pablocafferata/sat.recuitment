using Sat.Recruitment.Api.Models;
using Sat.Recruitment.Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sat.Recruitment.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository() { }

        public bool IsUserDuplicated(IUser user)
        {
            var isDuplicated = false;

            var reader = ReadUsersFromFile();

            while (reader.Peek() >= 0)
            {
                var line = reader.ReadLineAsync().Result;

                var name = line.Split(',')[0].ToString();
                var email = line.Split(',')[1].ToString();
                var phone = line.Split(',')[2].ToString();
                var address = line.Split(',')[3].ToString();

                if (user.Email == email || user.Phone == phone || (user.Name == name && user.Address == address))
                {
                    isDuplicated = true;
                    break;
                }
            }

            reader.Close();

            return isDuplicated;

        }

        private static StreamReader ReadUsersFromFile()
        {
            var path = Directory.GetCurrentDirectory() + "/Files/Users.txt";

            FileStream fileStream = new(path, FileMode.Open);

            StreamReader reader = new(fileStream);

            return reader;
        }
    }
}
