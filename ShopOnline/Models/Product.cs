namespace ShopOnline.Models;

public class Product
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Imgage { get; set; } = default!;
    public string Title { get; set; } = default!;
    public string Content { get; set; } = default!;
    public string Detail { get; set; } = default!;
    public decimal Price { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public int Quantity { get; set; }
}