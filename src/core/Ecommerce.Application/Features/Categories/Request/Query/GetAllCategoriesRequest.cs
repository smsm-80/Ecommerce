using MediatR;
namespace Ecommerce.Application.Features.Request.Query;
public class GetAllCategoriesRequest:IRequest<List<CategoryDTO>>
{
}
