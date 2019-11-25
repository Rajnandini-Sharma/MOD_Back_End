using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD_PaymentService.Models;
using MOD_PaymentService.Repository;

namespace MOD_PaymentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository _payrepository;
        public PaymentController(IPaymentRepository repository)
        {
            _payrepository = repository;
        }
        // GET: api/Payment/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // GET: api/Payment/GetAll
        [HttpGet]
        [Route("GetAll")]
        public List<Payment> GetAll()
        {
            return _payrepository.GetAll();
        }

        // POST: api/Payment
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Payment item)
        {
            _payrepository.Add(item);
            return Ok("Record Added..");
        }

    }
}
