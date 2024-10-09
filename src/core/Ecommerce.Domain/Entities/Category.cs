namespace Ecommerce.Domain.Entities;

public class Category:BaseEntity<int>
{
    public Category(string name,string description) 
    {
        this.Name = name;
        this.Description = description;
    }
    public string Name { get; set; }
    public string Description { get; set; }
}
