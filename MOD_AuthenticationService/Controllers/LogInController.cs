using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOD_AuthenticationService.Models;
using MOD_AuthenticationService.Repository;

namespace MOD_AuthenticationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        private readonly IAuthRepository _repository;
        public LogInController(IAuthRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("Validate/{email}/{pwd}")]
        public Token Get(string email, string pwd)
        {
            if (_repository.StudentLogin(email, pwd)!=null)
            {
                Student response = _repository.StudentLogin(email, pwd);
                return new Token() { message = "User", token = response.Student_Id.ToString() };
            }
            else if (_repository.MentorLogin(email, pwd)!=null)
            {
                Mentor response = _repository.MentorLogin(email, pwd);
                return new Token() { message = "Mentor", token = response.MentorId.ToString() };
            }
            else if (email == "123" && pwd == "admin")
            {
                return new Token() { message = "Admin", token = GetToken() };
            }
            else
            {
                return new Token() { message = "Invalid User", token = "" };
            }
        }
        public string GetToken()
        {
            return "";
        }

    }
}
