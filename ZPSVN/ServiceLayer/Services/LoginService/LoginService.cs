using DataBaseLayer.Models;
using ServiceLayer.Repositories;
using ServiceLayer.Services.CRUD_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceLayer.Services.LoginService
{
    public class LoginService: UserService, IService
    {
        private UserRepository _userRepository;

        public LoginService(UserRepository repository):base(repository)
        {
            _userRepository = repository;
        }
        public bool CheckAuth(string username, string password)
        {
            foreach (User user in _userRepository.GetAll())
            {
                if (username == user.Name && password == user.Password)
                {
                    MessageBox.Show($"Welcome, {user.Name}!");
                    return true;
                }
            }

            MessageBox.Show("The username or the password are not valid!");
            return false;
        }
    }
}
