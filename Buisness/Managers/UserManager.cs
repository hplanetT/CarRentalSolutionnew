using DataAccess.Repositories;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Managers
{
    public class UserManager
    {
        private readonly UserRepository _userRepository;

        public UserManager()
        {
            _userRepository = new UserRepository(new AppDbContext());
        }

        public User ValidateUser(string username, string password)
        {
            User user = _userRepository.GetByUsername(username);
            if (user != null && user.PasswordHash == password) 
            {
                return user;
            }
            return null;
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public void AddUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.PasswordHash))
            {
                throw new System.Exception("Kullanıcı adı ve şifre boş olamaz.");
            }
            _userRepository.Add(user);
        }
    }
}
