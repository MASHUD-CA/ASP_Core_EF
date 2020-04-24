using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Core_EF.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        // Added title
        [DisplayName("Course Name")]
        //Added validation
        [Required(ErrorMessage ="Course Name is Required.")]
        public string CourseName { get; set; }

        //Added validaton
        [Required(ErrorMessage ="Credits is Required.")]
        public string Credits { get; set; }

    }
}
