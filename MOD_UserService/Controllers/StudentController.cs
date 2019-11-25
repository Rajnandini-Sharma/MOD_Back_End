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
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _strepository;
        public StudentController(IStudentRepository repository)
        {
            _strepository = repository;
        }

        // GET: api/Student/GetAll
        [HttpGet] 
        [Route("GetAll")]
        public List<Student> Get()
        {
            return _strepository.GetAll();
        }
        [HttpGet]
        [Route("User_Search_Mentor/{skills}/{from_timeslot}/{to_timeslot}")]
        public List<Mentor> User_Search_Mentor(string skills, string from_timeslot, string to_timeslot)
            {
            return _strepository.User_Search_Mentor(skills, from_timeslot, to_timeslot);
        }
        // POST: api/Student
      [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Student item)
        {
            _strepository.Add(item);
            return Ok("Record Added..");
        }

        // PUT: api/Student/5
        [HttpPut("{id}")]
        [Route("Update")]
        public void Put(Student item)
        {
            _strepository.Update(item);
        }

        // DELETE: api/Student/Delete/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(long id)
        {
            _strepository.Delete(id);
        }
        [HttpPut("{id}")]
        [Route("BlockUser/{id}")]
        public void Block(long id)
        {
            _strepository.BlockUser(id);
        }
        [HttpPut("{id}")]
        [Route("UnBlockUser/{id}")]
        public void UnBlock(long id)
        {
            _strepository.UnBlockUser(id);
        }
    }
}
