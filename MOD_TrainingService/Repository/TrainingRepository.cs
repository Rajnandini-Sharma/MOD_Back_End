using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD_TrainingService.Context;
using MOD_TrainingService.Models;

namespace MOD_TrainingService.Repository
{
    public class TrainingRepository : ITrainingRepository
    {
        private readonly TrainingContext _context;
        public TrainingRepository(TrainingContext context)
        {
            _context = context;
        }
        public void Trng_Add(Training item)
        {
            try
            {
                _context.Training.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            { }

        }

        public void Delete(string id)
        {
            var item = _context.Training.Find(id);
            _context.Training.Remove(item);
            _context.SaveChanges();
        }

        public List<Training> GetAll()
        {
            return _context.Training.ToList();
        }

        public void Update(Training item)
        {
            _context.Entry(item).State =
                   Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
        public List<Training> GetTrainingByUserId(long id)
        {
            return _context.Training.Where(i => i.Student_Id == id).ToList();
        }
        public List<Training> GetTrainingByMentorId(long id)
        {
            return _context.Training.Where(i => i.MentorId == id).ToList();
        }

    }
}
