namespace MovieRentalBackend.Models
{
    public class Movie
    {
        public required string Title { get; set; }
        public required string Genre { get; set; }
        public required string Language { get; set; }
        public required string Director { get; set; }
        public int YearOfRelease { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; } = 10;  // Default stock of 10 copies
    }
}
