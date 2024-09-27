using DataBaseLayer.DataBaseContext;
using DataBaseLayer.Models;
using static DataBaseLayer.Models.User;

namespace ServiceLayer.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(SvnStatusInfoContext dbContext) : base(dbContext)
        {
        }
        public void ChangeRole(User user, UserAccessRole role)
        {
            foreach (User person in GetAll())
            {
                if (person.Id != user.Id)
                {
                    user.Role = role;
                    Update(person, user);
                    break;
                }
            }
        }
        public UserAccessRole CheckRole(string Username)
        {
            foreach (User user in GetAll())
            {
                if (user.Name == Username)
                {
                    return user.Role;
                }
            }
            return 0;
        }
    }
}
