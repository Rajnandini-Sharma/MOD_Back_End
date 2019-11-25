using MOD_TrainingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_TrainingService.Repository
{
    public interface ITrainingRepository
    {
        void Trng_Add(Training item);
        List<Training> GetAll();
        void Update(Training item);
        void Delete(string id);
        List<Training> GetTrainingByUserId(long id);
        List<Training> GetTrainingByMentorId(long id);

    }
}
