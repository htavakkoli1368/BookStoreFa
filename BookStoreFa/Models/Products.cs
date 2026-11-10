namespace BookStoreFa.Models
{
    public class Products
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public bool IsPublished { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
