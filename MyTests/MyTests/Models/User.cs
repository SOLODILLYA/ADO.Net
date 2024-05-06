using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyTests.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Login { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required]
        public int RoleId { get; set; }

        //Navigation Properties:
        public virtual Role Role { get; set; }
        public virtual List<Grade> Grades { get; set; }
        public virtual List <Test> Tests { get; set; }
    }
}
