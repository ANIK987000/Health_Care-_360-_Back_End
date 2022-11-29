using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class HospitalPatient
    {
        public int ID { get; set; }
        [Required]
        [ForeignKey("Hospital")]
        public int HospitalID { get; set; }
        [Required]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
