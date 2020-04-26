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

    public enum Status
    {
        Undergraduate, Postgraduate, PhD, suspended
    }
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        //Display name and Validation
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        [DisplayName("Date of Birth")]
        [Required(ErrorMessage = "DOB is Required")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [DisplayName("Gender Status")]
      //  [Required(ErrorMessage = "Gender is Required")]
        public int GenderId { get; set; }

        [DisplayName("Registration Date")]
        [Required(ErrorMessage = "Registration Date is Required")]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }

        [DisplayFormat(NullDisplayText ="No Status")]
        // Status = an enumerated type (? in front of Status = can be null )
        public Status? Status { get; set; }
        
        //added properties
        public Gender Genders { get; set; }

        //Added properties for Detail link
        public ICollection<Enrollment> Enrollments { get; set; }
        
    }
}
