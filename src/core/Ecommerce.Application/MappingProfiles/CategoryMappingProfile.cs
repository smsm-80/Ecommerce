using AutoMapper;

namespace Ecommerce.Application.MappingProfiles;
public class CategoryMappingProfile:Profile
{
    public CategoryMappingProfile() 
    {
        // Configure Automapper
        CreateMap<Category, CategoryDTO>().ReverseMap();
    }

}
