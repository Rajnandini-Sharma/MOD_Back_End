using MOD_TechnologyService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_TechnologyService.Repository
{
   public interface ITechnologyRepo
    {
        void Add(Technology item);
        List<Technology> GetAll();
        Technology GetById(long id);
        void Update(Technology item);
        void Delete(long id);

    }
}
