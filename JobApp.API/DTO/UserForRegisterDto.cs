using System.ComponentModel.DataAnnotations;

namespace JobApp.API.DTO
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username {get; set;}

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage= "Must be between 4-8 characters")]
        public string Password {get; set;}
        
    }
}