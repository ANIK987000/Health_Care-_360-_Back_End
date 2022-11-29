using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class HospitalStaff
    {
        public int ID { get; set; }
        [Required]
        [ForeignKey("Hospital")]
        public int HospitalID { get; set; }
        [Required]
        [ForeignKey("Staff")]
        public int StaffID { get; set; }

        public virtual Staff Staff { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
