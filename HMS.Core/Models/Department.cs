using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HMS.Core.Models
{
    public class Department
    {
        [Key]
        public int deptId { get; set; }
        [MaxLength(32)]
        [Required]
        public string Name { get; set; }

        //Navigation property with patient
        //public List<Patient> Patients { get; set; }
    }
}
