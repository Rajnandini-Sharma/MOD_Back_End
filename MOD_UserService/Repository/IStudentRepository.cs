using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD_UserService.Models;

namespace MOD_UserService.Repository
{
    public interface IStudentRepository
    {
        void Add(Student item);
        List<Student> GetAll();
        void Update(Student item);
        public List<Mentor> User_Search_Mentor(string skills, string from_timeslot, string to_timeslot);
        void Delete(long id);
        void BlockUser(long id);
        void UnBlockUser(long id);

    }
}
