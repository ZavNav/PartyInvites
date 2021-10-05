using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "TEL ME YOUR NAME, BOY")]
        public string Name { get; set; }
        [Required(ErrorMessage = "EMAIL, DO YOU SPEAK IT?")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Add some @s or .s")]
        public string Email { get; set; }
        [Required(ErrorMessage = "I THINK YOU NAD TO DO THIS")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "I NEED TO NO THE ANSWER")]
        public bool? WillAttend { get; set; }
    }
}