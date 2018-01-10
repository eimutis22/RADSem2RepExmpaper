using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RADSem2RepExam.Models.StudentModels
{
    [Table("Attendances")]
    public class Attendance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttendanceID { get; set; }

        [ForeignKey("assocModule")]
        [Display(Name = "Module ID")]
        public int ModuleID { get; set; }

        [ForeignKey("assocStudent")]
        [Display(Name = "Student ID")]
        public string StudentID { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Attendance DateTime")]
        public DateTime AttendanceDateTime { get; set; }

        [Display(Name = "Present")]
        public bool Present { get; set; }

        public virtual Student assocStudent { get; set; }
        public virtual Module assocModule { get; set; }
    }
}