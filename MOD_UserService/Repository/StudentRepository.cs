using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOD_UserService.Context;
using MOD_UserService.Models;
using MOD_UserService.Repository;

namespace MOD.UserService.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext _context;

        public StudentRepository(StudentContext context)
        {
            _context = context;
        }
        public void Add(Student item)
        {
            try
            {
                _context.Student.Add(item);
                _context.SaveChanges();
            }
            catch(Exception)
            { }
        }

        public void Delete(long id)
        {
            var item = _context.Student.Find(id);
            _context.Student.Remove(item);
            _context.SaveChanges();
        }

        public List<Student> GetAll()
        {
            return _context.Student.ToList();
        }
        public void Update(Student item)
        {
            _context.Entry(item).State =
                   Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public List<Mentor> User_Search_Mentor(string skills, string from_timeslot, string to_timeslot)
        {
              return (from f in _context.Mentor where
                    f.Mentor_skills == skills &&
                    f.From_Time_slot == from_timeslot &&
                    f.To_Time_slot == to_timeslot select f).ToList();
        }
        public void BlockUser(long id)
        {
            var item = _context.Student.Find(id);
            if (item.Student_active == true)
            {
                item.Student_active = !(item.Student_active);
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void UnBlockUser(long id)
        {
            var item = _context.Student.Find(id);
            if (item.Student_active == false)
            {
                item.Student_active = !(item.Student_active);
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
