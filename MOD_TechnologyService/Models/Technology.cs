using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_TechnologyService.Models
{
    [Table("Technology")]
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
