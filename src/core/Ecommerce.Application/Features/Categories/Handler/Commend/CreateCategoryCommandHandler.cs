using Ecommerce.Application.Features.Categories.Request.Commend;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Categories.Handler.Commend
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, Unit>
    {
        public ICategoryRepository _CategoryRepository { get; }
        public IMapper _Mapper { get; }
        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository,IMapper mapper) 
        {
            _CategoryRepository = categoryRepository;
            _Mapper = mapper;
        }


        public async Task<Unit> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var Category = _Mapper.Map<Category>(request.categoryDTO);
            await _CategoryRepository.CreateAsync(Category);
            return Unit.Value;
        }
    }
}
