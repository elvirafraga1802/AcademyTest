using AcademyTest.Entities;

namespace AcademyTest.Repositories
{
    public interface IUserRepository
    {
        User CreateUser(Guid id);
        User ReadItem(Guid id);
        User UpdateUser(Guid id);
        User DeleteUser(Guid id);
        Task<List<User>> GetUsers();
        
        
        
        
    }
}