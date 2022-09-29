using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DTSMCC_Exam2.Models
{
    public class UserRole
    {
        [Key]
        public int id { set; get; }

        public User user { set; get; }
        [ForeignKey("User")]
        public int userId { set; get; }

        public Role Role { set; get; }
        [ForeignKey("Role")]
        public int roleId { set; get; }
    }
}
