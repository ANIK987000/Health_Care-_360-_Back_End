using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class DoctorPatient
    {
        public int ID { get; set; }
        [Required]
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        [Required]
        [ForeignKey("Doctor")]
        public int DoctorID { get; set; }
    }
}
