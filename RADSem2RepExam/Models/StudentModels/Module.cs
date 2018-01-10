using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RADSem2RepExam.Models.StudentModels
{
    [Table("Modules")]
    public class Module
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModuleID { get; set; }

        [Display(Name = "Module Name")]
        public string ModuleName { get; set; }

        public virtual ICollection<Attendance> attendances { get; set; }
    }
}