namespace Ecommerce.Application.DTOs.Entities;

public class ProductDTO:BaseDTO<int>
{
    public string Nmae { get; set; }
    public decimal Price { get; set; }
}
