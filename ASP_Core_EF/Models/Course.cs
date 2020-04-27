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

        // Added title and Validation
        [DisplayName("Course Name")]
        [Required(ErrorMessage ="Course Name is Required.")]
        [StringLength(10)]
        public string CourseName { get; set; }

        //Added validaton
        [Required(ErrorMessage ="Credits is Required.")]
        [StringLength(10)]
        public string Credits { get; set; }

        //Added properties for Detail link of courses
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
