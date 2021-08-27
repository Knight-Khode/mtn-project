using System.ComponentModel.DataAnnotations;

namespace Church_Web.Models
{
    public class UserViewModel
    {
        public class LoginUserDto
        {
            [Required(ErrorMessage = "Required")]
            [StringLength(50, ErrorMessage = "Must be between 5 and 50 characters", MinimumLength = 5)]
            public string Username { get; set; }

            [Required(ErrorMessage = "Password is required")]
            [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$")]
            [StringLength(50, ErrorMessage = "Must be between 8 and 50 characters", MinimumLength = 8)]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        public class RegisterUserDto : LoginUserDto
        {

            [DataType(DataType.Password)]
            [Compare("Password")]
            public string ConfirmPassword { get; set; }

            [Required(ErrorMessage = "Required")]
            [StringLength(100, ErrorMessage = "Must be between 10 and 100 characters", MinimumLength = 10)]
            public string FullName { get; set; }

            [Required(ErrorMessage = "Email is required")]
            [StringLength(50, ErrorMessage = "Must be between 5 and 50 characters", MinimumLength = 5)]
            [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Required")]
            [StringLength(10, ErrorMessage = "Must be between 8 and 10 characters", MinimumLength = 10)]
            public string PhoneNumber { get; set; }
        }
    }
}
