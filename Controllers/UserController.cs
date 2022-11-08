using AcademyTest.Dtos;
using AcademyTest.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AcademyTest.Controllers
{
    [ApiController]
    [Route("users")]

    public class UserController : ControllerBase
    {

        private readonly IUserRepository repository;

        public UserController(IUserRepository repository)
        {
            this.repository = repository;
        }


        [HttpGet("GetAll")]
        public IEnumerable<UserDto> GetUsers()
        {
            var items = repository.GetUsers().Select( item => item.AsDto());
            return items;
        }
        

    }
}