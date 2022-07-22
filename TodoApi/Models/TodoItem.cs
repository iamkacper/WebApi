using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TodoItem
    {
        [Required]  
        public long Id { get; set; }

        [Range(1000000000000000, 9999999999999999, ErrorMessage = "Please enter a valid card number. xxxx-xxxx-xxxx-xxxx")]
        public string? CardNumber { get; set; }

        [Range(100, 999, ErrorMessage = "Please enter a valid CVV.")]
        public string? CardSecurityCode { get; set; }

        [Range((0.1), 100, ErrorMessage = "Price must be between €0.1 and €100")]
        public string? Amount { get; set; }

        public string? Currency { get; set; }
        public string? Secret { get; set; }

    }
}