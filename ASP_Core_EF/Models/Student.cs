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

    public enum Status
    {
        Undergraduate, Postgraduate, PhD, suspended
    }
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public int GenderId { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }

        // Status = an enumerated type (? in front of Status = can be null )
        public Status? Status { get; set; }
        
        //added properties
        public Gender Genders { get; set; }
        
    }
}
