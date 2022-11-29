using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class HospitalDoctor
    {
        
        public int ID { get; set; }
        [Required]
        [ForeignKey("Hospital")]
        public int HospitalID { get; set; }
        [Required]
        [ForeignKey("Doctor")]
        public int DoctorID { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
