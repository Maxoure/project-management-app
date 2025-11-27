using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectManagement.Api.Interfaces.User;
using ProjectManagement.Api.Models;

namespace ProjectManagement.Api.Services.User
{
    public class UserServices : IUserServices
    {
        private readonly List<UserModel> _users = new List<UserModel>();
        public async Task<IEnumerable<UserModel>> GetAllUsers() => _users;

        public async Task<UserModel?> GetUserById(int id) => _users.FirstOrDefault(u => u.Id == id);

        public async Task<UserModel> CreateUser(UserModel user)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
            return user;
        }

        public void UpdateUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}