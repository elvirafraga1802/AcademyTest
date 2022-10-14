using AcademyTest.Entities;

namespace AcademyTest.Repositories
{
    public class InMemUserRepository : IUserRepository
    {

        private readonly List<User> users = new()
        {
            new User{Id = Guid.NewGuid(),Name = "Elvira", Email = "elvira.fraga@hotmail.com", Phone = 4427127244},
            new User{Id = Guid.NewGuid(),Name = "Andres", Email = "20", Phone = 44267425961},
            new User{Id = Guid.NewGuid(),Name = "Gustavo", Email = "", Phone = 4427895614 }
        };

        public User GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers(Guid id)
        {
            return (IEnumerable<User>)users.Where(users => users.Id == id).SingleOrDefault();
        }

        public void CreateUser(User user)
        {
            users.Add(user);
        }
    }
}