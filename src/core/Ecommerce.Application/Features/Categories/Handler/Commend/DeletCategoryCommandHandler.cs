using Ecommerce.Application.Features.Categories.Request.Commend;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Categories.Handler.Commend
{
    public class DeletCategoryCommandHandler : IRequestHandler<DeletCategoryCommand>
    {
        public ICategoryRepository _CategoryRepository { get; }
        public DeletCategoryCommandHandler(ICategoryRepository categoryRepository) 
        {
            _CategoryRepository = categoryRepository;
        }


        public async Task<Unit> Handle(DeletCategoryCommand request, CancellationToken cancellationToken)
        {

            var CategoriesToBeDeleted = await _CategoryRepository.GetAsync(request.ID);
            await _CategoryRepository.DeleteAsync(CategoriesToBeDeleted.ID);
            return Unit.Value;
        }


    }
}
