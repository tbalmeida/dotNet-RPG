using dotNet_RPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNet_RPG.Data
{
    public class AuthRepository : IAuthRepository
    {

        public Task<ServiceResponse<int>> Register(User user, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<ServiceResponse<string>> Login(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UserExists(string username)
        {
            throw new System.NotImplementedException();
        }

    }
}
