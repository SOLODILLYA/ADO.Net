using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetExam.Models
{
    public class Contract
    {
        public int Id { get; set; }

        [Required]
        public int FlatId { get; set; }

        [Required]
        public int UserId { get; set; }

        public virtual List<Flat> Flats { get; set; }
        public virtual User User { get; set; }

    }
}
