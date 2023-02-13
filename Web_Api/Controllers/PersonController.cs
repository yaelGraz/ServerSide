using Microsoft.AspNetCore.Mvc;
using Server.Repository.Entities;
using Services.Interfaces;
using Services.Models;
using Services.ServiceClasses;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        IBllService _personService;
        public PersonController(IBllService service)
        {
            _personService = service;
        }

        // GET: api/<PersonController>
        [HttpGet]
        public async Task<IEnumerable<PersonModel>>Get()
        {
            var result = await _personService.GetAllAsync();
            return result;
        }

        // GET api/<PersonController>/id
        [HttpGet("{id}")]
        public async Task<PersonModel> GetByIdNumber(string id)
        {
            return await _personService.GetByIdNumberAsync(id);
        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<PersonModel> Post([FromBody] PersonModel person)
        {
            //PersonModel userToAdd = new PersonModel()
            //{
            //    //UserId = person.UserId,
            //    //FirstName = person.FirstName,
            //    //LastName = person.LastName,
            //    //Children = person.Children,
            //    //BirthDate= person.BirthDate,
            //    //HMO = person.HMO,
            //    //Gender = person.Gender
            //};
            return await _personService.AddAsync(person);
           
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public async Task<PersonModel> Put([FromBody] PersonModel person)
        {
            return await _personService.UpdateAsync(person);
        }
        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _personService.DeleteAsync(id);
        }
    }
}
