using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD_TrainingService.Models;
using MOD_TrainingService.Repository;

namespace MOD_TrainingService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITrainingRepository _trainingrepository;
        public TrainingController(ITrainingRepository repository)
        {
            _trainingrepository = repository;
        }

        // GET: api/Training/GetAll
        [HttpGet]
        [Route("GetAll")]
        public List<Training> Get()
        {
            return _trainingrepository.GetAll();
        }
        // POST: api/Training
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Training item)
        {
            _trainingrepository.Trng_Add(item);
            return Ok("Record Added..");
        }

        // PUT: api/Training/5
        [HttpPut("{id}")]
        [Route("Update/{id}")]
        public void Put(Training item)
        {
            _trainingrepository.Update(item);
        }

        // DELETE: api/Training/Delete/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(string id)
        {
            _trainingrepository.Delete(id);
        }
        [HttpGet("{id}", Name = "Get")]
        [Route("GetTrainingByUser/{id}")]
        public List<Training> Get(int id)
        {
            return _trainingrepository.GetTrainingByUserId(id);
        }
        [HttpGet("{id}", Name = "Get")]
        [Route("GetTrainingByMentor/{id}")]

        public List<Training> GetbyMentor(int id)
        {
            return _trainingrepository.GetTrainingByMentorId(id);

        }

    }
}
