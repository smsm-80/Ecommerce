using Ecommerce.Application.Features.Categories.Request.Commend;
using Ecommerce.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Categories.Handler.Commend
{
    public class UpdateCategoryCommandHandlerL : IRequestHandler<UpdateCategoryCommand, Unit>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public UpdateCategoryCommandHandlerL(ICategoryRepository categoryRepository,IMapper mapper) 
        {
            this._categoryRepository = categoryRepository;
            this._mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var OldCategory = await _categoryRepository.GetAsync(request.categoryDTO.Id);
            var UpdatedCategory = _mapper.Map(request.categoryDTO, OldCategory);
            await _categoryRepository.UpdateAsync(UpdatedCategory);
            return Unit.Value;
        }
    }
}
