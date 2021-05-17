using System.ComponentModel.DataAnnotations;

namespace LearnerBikes.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Email is required")]
        [StringLength(30, ErrorMessage = "Email length must be less than 320 characters")]
        public string senderEmail { get; set; }
        [Required(ErrorMessage = "Message is required")]
        [MinLength(5, ErrorMessage = "Message must be more than 3 characters")]
        public string senderMessage { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, ErrorMessage = "Name length must be less than 30 characters")]
        public string senderName { get; set; }
    }
}
