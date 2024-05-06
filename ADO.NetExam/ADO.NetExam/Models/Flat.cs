using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NetExam.Models
{
    public class Flat
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int DistrictId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Adress { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal Size { get; set;}

        [Required]
        public bool IsAvailable { get; set; }

        [Required]
        public bool IsPetsAllowed { get; set; }

        [Required]
        public int Floors { get; set; }

        [Required]
        public int HowManyPeopleSuits { get; set;}

        public int? ContractId { get; set; }

        public virtual District District { get; set; }
        public virtual Contract Contract { get; set; }

    }
}
 