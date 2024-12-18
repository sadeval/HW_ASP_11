using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HW_ASP_11.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Username must not exceed 20 characters.")]
        [RegularExpression(@"^\w+$", ErrorMessage = "Username can only contain letters, numbers, and underscores.")]
        [Remote(action: "IsUsernameAvailable", controller: "Account", ErrorMessage = "Username already taken.")]
        public string Username { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        [StringLength(100)]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format.")]
        public string PhoneNumber { get; set; }

        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100.")]
        public int Age { get; set; }

        [Url(ErrorMessage = "Invalid URL format.")]
        public string Website { get; set; }

        [ValidateNever]
        public bool TermsOfService { get; set; }

        [CreditCard(ErrorMessage = "Invalid credit card number.")]
        public string CreditCardNumber { get; set; }
    }
}
