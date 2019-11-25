using MOD_UserService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_UserService.Repository
{
    public interface IMentorRepository
    {
        void Add(Mentor item);
        List<Mentor> GetAll();
        void Update(Mentor item);
        void Delete(long id);
        void BlockMentor(long id);
        void UnBlockMentor(long id);
    }

}
