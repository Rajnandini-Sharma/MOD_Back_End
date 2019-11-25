using MOD_AuthenticationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_AuthenticationService.Repository
{
   public interface IAuthRepository
    {
        Student StudentLogin(string email, string pwd);
        Mentor MentorLogin(string email, string pwd);
    }
}
