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

        [StringLength(4, ErrorMessage = "Please enter a valid Expiry date.")] // [Range(1000, 9999, ErrorMessage = "Please enter a valid Expiry date.")]
        public string? ExpiryDate { get; set; }

        [Range((0.1), 100, ErrorMessage = "Price must be between €0.1 and €100")]
        public string? Amount { get; set; }

        public string? Currency { get; set; }

        public string? Secret { get; set; }


        /*
         * 
         * 
    {
        private const string X = "Please enter a valid card number. xxxx-xxxx-xxxx-xxxx";
        private const string Y = "Please enter a valid CVV.";
        private const string Z = "Price must be between €0.1 and €100";
        private const string V = "Please enter a valid date.";

        [Required]  
        public long Id { get; set; }

        [Range(1000000000000000, 9999999999999999, ErrorMessage = X)]
        public string? CardNumber { get; set; }

        [Range(100, 999, ErrorMessage = Y)]
        public string? CardSecurityCode { get; set; }

        [Range((0.1), 100, ErrorMessage = Z)]
        public string? Amount { get; set; }

        public string? Currency { get; set; }

        [Range(1000, 9999, ErrorMessage = V)]
        public string? ExpiryDate { get; set; }

        public string? Secret { get; set; }

    } 
         */
    }
}