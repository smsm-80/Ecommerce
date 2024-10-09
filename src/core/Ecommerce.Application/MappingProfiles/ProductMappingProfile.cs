

namespace Ecommerce.Application.MappingProfiles;

public class ProductMappingProfile:Profile
{
    // Configure Automapper
    ProductMappingProfile()
    {
        CreateMap<Product, ProductDTO>().ReverseMap();
    }
}
