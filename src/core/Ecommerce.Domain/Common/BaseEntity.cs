namespace Ecommerce.Domain.Common;

public abstract class BaseEntity<T>
{
    public T? ID { get; set; }
    public Boolean Deleted { get; set; }
    public int CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public int ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
     
}
