using Ecommerce.Application.DTOs.Entities;
using MediatR;
namespace Ecommerce.Application.Features.Products.Request.Query;

public class GetAllProductsRequest : IRequest<List<ProductDTO>>
{
}
