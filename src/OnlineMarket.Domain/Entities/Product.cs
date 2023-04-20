using OnlineMarket.Domain.Commons;

namespace OnlineMarket.Domain.Entities;

public class Product : Auditable
{
    public string Name { get; set; } = string.Empty;
    public int Count { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
}
