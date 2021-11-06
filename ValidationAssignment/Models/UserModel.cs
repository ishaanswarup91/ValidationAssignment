using ValidationAssignment.Attributes;
using System.ComponentModel.DataAnnotations;

namespace ValidationAssignment.Models
{
    public class UserModel
    {
       
        [Required(ErrorMessage = "Please Enter Name")]
        [StringLength(100)]
        public string  Name { get; set; }

        [Required(ErrorMessage = "Please Enter UserName")]
        [MinLength(3)]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]

        [DataType(DataType.Password)]        
        [RegularExpression(@"^(?=.*\d)(?=.*[A-Z])(?=.*[@#$%^&+=]).{6,}$", ErrorMessage = "Password should be atleast six characters long and must have at least one Uppercase letter, number and special characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirm password does not match")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Please Enter Phone Number")]
        [RegularExpression("^[6,7,8,9]\\d{9}$", ErrorMessage = "Please Enter Correct Contact No.")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please Select Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please Select City")]
        public string City { get; set; }
               
        [Required(ErrorMessage = "Please Choose Gender")]
        public string Gender { get; set; }

        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        public bool AcceptTerms { get; set; }
    }
}
