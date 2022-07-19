namespace TodoApi.Models
{
    public class PaymentDTO
    {
        public long ClientId { get; set; }
        public long CardNumber { get; set; }    
        public long Amount { get; set; }    
        public string? Currency { get; set; }
        public bool IsComplete { get; set; }
    }
}