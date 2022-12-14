using Microsoft.AspNetCore.Mvc;
using Joker_APIGroupProject.Interface;
using Joker_APIGroupProject.Models;
using Joker_APIGroupProject.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Joker_APIGroupProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpyController : ControllerBase
    {

        public SpyController(ISpy SpyRepository)
        {
            _spyRepo = SpyRepository;
        }

        private ISpy _spyRepo;


        // GET: api/<ValuesController>
        [HttpGet]
        public List<Spy> GetAllSpies()
        {
            return _spyRepo.GetAll();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Spy Get(int id)
        {
            return _spyRepo.GetById(id);
        }

        [HttpGet("{id}Enemies")]
        public List <string> GetEnemiesById(int id)
        {
            return _spyRepo.GetEnemiesById(id);
        }

        [HttpGet("{id}Friends")]
        public List<string> GetFriendsById(int id)
        {
            return _spyRepo.GetFriendsById(id);
        }

        [HttpGet("{skills}skill")]
        public List<Spy> GetSpysBySkill(string skill)
        {
            return _spyRepo.GetSpysBySkill(skill);
        }

        [HttpGet("allSkills")]
        public List<string> GetAllSkills()
        {
            return _spyRepo.GetAllSkills();
        }


        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] Spy value)
        {
            if (_spyRepo.Create(value))
            {
                return Created("", value);
            };
            return NotFound();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
