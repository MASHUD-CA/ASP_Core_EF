using System;
using System.Collections.Generic;
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
        public int StudentId { get; set; }
        public int CoutseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }

        // Grade = an enumerated type (? in front of Grade = can be null )
        public Grade? Grade { get; set; }
    }
}
