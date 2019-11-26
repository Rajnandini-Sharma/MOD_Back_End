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
    public class MentorRepository : IMentorRepository
    {
        private readonly StudentContext _context;
        public MentorRepository(StudentContext context)
        {
            _context = context;
        }

        public void Add(Mentor item)
        {
            try { 
            _context.Mentor.Add(item);
            _context.SaveChanges();
            }
            catch (Exception)
            { }
        }

        public void Delete(long id)
        {
            var item = _context.Mentor.Find(id);
            _context.Mentor.Remove(item);
            _context.SaveChanges();
        }
        public List<Mentor> GetAll()
        {
            return _context.Mentor.ToList();
        }
        public void Update(Mentor item)
        {
            _context.Entry(item).State =
                   Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public void BlockMentor(long id)
        {
            var item = _context.Mentor.Find(id);
            item.Mentor_active = !(item.Mentor_active);
            item.Mentor_Avail = !(item.Mentor_Avail);
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void UnBlockMentor(long id)
        {
            var item = _context.Mentor.Find(id);
            if (item.Mentor_active == false)
            {
                item.Mentor_active = !(item.Mentor_active);
            }
            if(item.Mentor_Avail == false)
            {
                item.Mentor_Avail = !(item.Mentor_Avail);
            }
           _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
            
        }
        
    }
