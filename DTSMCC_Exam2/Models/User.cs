using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DTSMCC_Exam2.Models
{
    public class User
    {
        public Employee Employee { set; get; }
        [Key][ForeignKey("Enployee")]
        public int id { set; get; }
        public string password { set; get; }

    }
}
