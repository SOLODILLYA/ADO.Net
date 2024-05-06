using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace MyTests.Models
{
    public class Answer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Text { get; set; }
        [Required]
        public bool Correct { get; set; }
        [Required]
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}
