using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD_UserService.Models;
using MOD_UserService.Repository;

namespace MOD_UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorController : ControllerBase
    {
        private readonly IMentorRepository _repository;
        public MentorController(IMentorRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Mentor/GetAll
        [HttpGet]
        [Route("GetAll")]
        public List<Mentor> Get()
        {
            return _repository.GetAll();
        }
        // POST: api/Mentor
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Mentor item)
        {
            _repository.Add(item);
            return Ok("Record Added..");
        }

        // PUT: api/Mentor/5
        [HttpPut("{id}")]
        [Route("Update")]
        public void Put(Mentor item)
        {
            _repository.Update(item);
        }

        // DELETE: api/Mentor/Delete/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
        [HttpPut("{id}")]
        [Route("BlockMentor/{id}")]
        public void Block(long id)
        {
            _repository.BlockMentor(id);
        }
        [HttpPut("{id}")]
        [Route("UnBlockMentor/{id}")]
        public void UnBlock(long id)
        {
            _repository.UnBlockMentor(id);
        }
    }
}
