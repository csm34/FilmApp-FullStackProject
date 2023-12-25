using System.ComponentModel.DataAnnotations;

namespace FilmApp.Data
{
    public class User{
        public int UserId { get; set; }
        public String? UserFirstName { get; set; }
        public String? UserLastName { get; set; }
        
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public String? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public String? Password { get; set; }
    }
}