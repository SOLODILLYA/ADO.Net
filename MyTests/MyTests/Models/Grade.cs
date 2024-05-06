using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MyTests.Models
{
    public class Grade
    {
        public int Id { get; set; }
        [Required]
        public int Mark {  get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int TestId { get; set; }
        [Required]
        public DateTime TestDay { get; set; }
        public virtual User User { get; set; }
        public virtual Test Test { get; set; }
    }
}
