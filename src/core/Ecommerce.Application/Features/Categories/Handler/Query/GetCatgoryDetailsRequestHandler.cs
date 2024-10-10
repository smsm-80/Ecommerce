using Ecommerce.Application.Features.Categories.Request.Query;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Categories.Handler.Query
{
    public class GetCatgoryDetailsRequestHandler : IRequestHandler<GetCatgoryDetailsRequest, CategoryDTO>
    {

    private readonly ICategoryRepository _repository;
    private readonly IMapper _mapper;

    public GetCatgoryDetailsRequestHandler(ICategoryRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
        public async Task<CategoryDTO> Handle(GetCatgoryDetailsRequest request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetAsync(request.ID);
            if (category is null)
                throw new Exception("no category found");

            return _mapper.Map<CategoryDTO>(category);
        }
    }
}
