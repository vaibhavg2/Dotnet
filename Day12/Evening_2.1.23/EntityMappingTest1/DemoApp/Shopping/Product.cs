using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping;

[Table("ProductInfo")]
public class Product
{
    [Column("ProductNo")]
    public int Id { get; set; }

    public decimal Price { get; set; }

    public int Stock { get; set; }

    //navigation property
    public List<Order> Orders { get; set; } = new();
}
