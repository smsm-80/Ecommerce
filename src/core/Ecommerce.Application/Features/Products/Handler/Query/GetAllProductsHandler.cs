using MediatR;
using Ecommerce.Application.Features.Products.Request.Query;
using Ecommerce.Application.DTOs.Entities;
namespace Ecommerce.Application.Features.Products.Handler.Query;

public class GetAllProductsHandler : IRequestHandler<GetAllProductsRequest, List<ProductDTO>>
{
    private readonly ICategoryRepository _repository;
    private readonly IMapper _mapper;

    public GetAllProductsHandler(ICategoryRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<ProductDTO>> Handle(GetAllProductsRequest request, CancellationToken cancellationToken)
    {
        var category = await _repository.GetAllAsync();
        List<ProductDTO> CategoryDtoRespons = _mapper.Map<List<ProductDTO>>(category);
        return CategoryDtoRespons;
    }
}
