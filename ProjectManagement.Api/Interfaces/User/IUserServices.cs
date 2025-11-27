using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectManagement.Api.Models;

namespace ProjectManagement.Api.Interfaces.User
{
    public interface IUserServices
    {
        Task<IEnumerable<UserModel>> GetAllUsers();
        Task<UserModel?> GetUserById(int id);
        Task<UserModel> CreateUser(UserModel user);
        void UpdateUser(UserModel user);
        void DeleteUser(int id);
    }
}