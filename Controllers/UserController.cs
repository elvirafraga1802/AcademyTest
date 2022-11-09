using AcademyTest.Dtos;
using AcademyTest.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AcademyTest.Controllers
{
    [ApiController]
    [Route("users")]

    public class UserController : ControllerBase
    {
        public IUserRepository _repo;
        public UserController(IUserRepository _repo)
        {
            this._repo = _repo;            
        }

        [HttpGet("GetAll")] 
        public async Task<List<UserDto>> GetUsers()
        {
            var a = await _repo.GetUsers();
            var b = a.Select(u => u.AsDto()).ToList();
            return b;
        }
        

    }
}