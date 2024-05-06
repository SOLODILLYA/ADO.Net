using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MyTests.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Text { get; set; }
        [Required]
        public int TestId { get; set; }
        public virtual List<Answer> Answers { get; set; }
        public virtual Test Test { get; set; }
    }
}
