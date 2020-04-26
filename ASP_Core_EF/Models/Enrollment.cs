using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Core_EF.Models
{
    // enum is value type data type. 
    // Enum used to declare list of named integer constants.
    // Defined enum keyword directly inside namespace, class, or structure. 
    // Used to give a name to each constant so that the constant integer can be referred using its name.

    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }

        //Adding Message & validation
        [Required(ErrorMessage ="Student is Required")]
        [DisplayName("Student Name")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Course is Required")]
        [DisplayName("Course Name")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Start Date is Required")]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is Required")]
        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }

        [DisplayFormat(NullDisplayText ="No Grade")]
        // Grade = an enumerated type (? in front of Grade = can be null )
        public Grade? Grade { get; set; }
    }
}
