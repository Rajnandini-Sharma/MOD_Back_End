using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_TrainingService.Models
{
    public class Technology
    {
        [Key]
        public long Tech_id { get; set; }
        public string Tech_name { get; set; }
        public string TOC { get; set; }

        public int Fees { get; set; }
        public int Duration { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
    }
}
