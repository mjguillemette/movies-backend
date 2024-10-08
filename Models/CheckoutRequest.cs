namespace MovieRentalBackend.Models
{
    public class CheckoutRequest
    {
        public string Title { get; set; } = string.Empty;
        public int Amount { get; set; }
    }
}