using MOD_AuthenticationService.Context;
using MOD_AuthenticationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_AuthenticationService.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly LoginContext _context;
        public AuthRepository(LoginContext context)
        {
            _context = context;
        }
        public Mentor MentorLogin(string email, string pwd)
        {
            try
            {
                return _context.Mentor.SingleOrDefault(data => data.Mentor_email == email && data.Mentor_Password == pwd);
                //if (obj != null)
                //    return true;
                //else
                //    return false;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public Student StudentLogin(string email, string pwd)
        {
            try
            {
                return _context.Student.SingleOrDefault(data => data.Student_email == email && data.Student_Password == pwd);
                //if (obj != null)
                //    return true;
                //else
                //    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }

    
}
