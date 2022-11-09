using AcademyTest.Context;
using AcademyTest.Dtos;
using AcademyTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcademyTest.Repositories
{
    public class UserService : IUserRepository
    {
        public DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;      
        }
      
     
        public User CreateUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public User DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public User ReadItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}