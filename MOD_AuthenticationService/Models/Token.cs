using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_AuthenticationService.Models
{
    [Table("Authentication")]
    public class Token
    {
        public string message { get; set; }
        public string token { get; set; }
    }
}
