using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD_TechnologyService.Models;
using MOD_TechnologyService.Repository;

namespace MOD_TechnologyService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologyController : ControllerBase
    {
        private readonly ITechnologyRepo _techrepository;
        public TechnologyController(ITechnologyRepo TechRepository)
        {
            _techrepository = TechRepository;
        }

        // GET: api/Technology/GetAll
        [HttpGet]
        [Route("GetAll")]
        public List<Technology> GetAll()
        {
            return _techrepository.GetAll();
        }

        // GET: api/Technology/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        // GET: api/Technology/5
        [HttpGet("{id}", Name = "Get")]
        public Technology GetById(long id)
        {
            return _techrepository.GetById(id);
        }

        // POST: api/Technology
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Technology item)
        {
            _techrepository.Add(item);
            return Ok();
        }

        // PUT: api/Technology/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Technology item)
        {
            _techrepository.Update(item);
            return Ok();
        }

        // DELETE: api/Technology/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _techrepository.Delete(id);
            return Ok();
        }
    }
}
