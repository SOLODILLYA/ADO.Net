using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyTests.Models
{
    public class Test
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public int SubjectId { get; set; }
        [Required]
        public int UserId { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual User User { get; set; }
        public virtual List<Grade> Grades { get; set; }
        public virtual List<Question> Questions { get; set; }
    }
}
