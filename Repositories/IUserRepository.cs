using AcademyTest.Entities;

namespace AcademyTest.Repositories
{
    public interface IUserRepository
    {
        User GetItem(Guid id);
        IEnumerable<User> GetUsers();
    }
}