using dotNet_RPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNet_RPG.Data
{
    public class IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);

        Task<ServiceResponse<string>> Login(string username, string password);

        Task<bool> UserExists(string username);
}
