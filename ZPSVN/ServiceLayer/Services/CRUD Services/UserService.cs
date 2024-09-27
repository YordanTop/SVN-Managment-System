using DataBaseLayer.Models;
using ServiceLayer.Repositories;
using System.Collections.Generic;
using static DataBaseLayer.Models.User;

namespace ServiceLayer.Services.CRUD_Services
{
    public class UserService: IService
    {
        private UserRepository _repository;

        public UserService(UserRepository repository)
        {
            this._repository = repository;
        }

        public void AddUser(User user)
        {
            _repository.Add(user);
        }
        public void RemoveUser(User user)
        {
            _repository.Delete(user);
        }

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }

        public User GetUserById(int id)
        {
            return _repository.GetById(id).Result;
        }

        public void UpdateUser(User oldInfo, User newInfo)
        {
            _repository.Update(oldInfo, newInfo);
        }
        public void ChangeRole(User user, UserAccessRole role)
        {
            _repository.ChangeRole(user, role);
        }

        public UserAccessRole CheckRole(string Username)
        {
            return _repository.CheckRole(Username);
        }
    }
}
