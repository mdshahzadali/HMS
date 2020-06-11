using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HMS.Core.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(32)]
        public string FirstName { get; set; }
        [MaxLength(32)]
        public string MiddleName { get; set; }
        [Required]
        [MaxLength(32)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(256)]
        public string Address { get; set; }
        [Required]
        [MaxLength(10)]
        public string ContactNumber { get; set; }
        [MaxLength(32)]
        public string RelativeName { get; set; }
        [Required]
        [MaxLength(256)]
        public string DesiesName { get; set; }


        //Navigation propery with Department
        //public int deptId { get; set; }
        //public Department Department { get; set; }
    }
}
