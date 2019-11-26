using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD_TechnologyService.Context;
using MOD_TechnologyService.Models;

namespace MOD_TechnologyService.Repository
{
    public class TechnologyRepo : ITechnologyRepo
    {
        private readonly TechnologyContext _context;
        public TechnologyRepo(TechnologyContext context)
        {
            _context = context;
        }

        public void Add(Technology item)
        {
            try
            {
                _context.Technology.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            { }
        }

        public void Delete(long id)
        {
            var item = _context.Technology.Find(id);
            _context.Technology.Remove(item);
            _context.SaveChanges();
        }

        public List<Technology> GetAll()
        {
            return _context.Technology.ToList();
        }

        public Technology GetById(long id)
        {
            return _context.Technology.Find(id);
        }

        public void Update(Technology item)
        {
            _context.Entry(item).State =
                   Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
