using Ecommerce.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Categories.Handlers.Command
{
    internal class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand>
    {
        private readonly ICategoryRepository _repository;

        public DeleteCategoryCommandHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            //get category by id
            var oldCategory = await _repository.GetAsync(request.ID);
            if (oldCategory is null)
                throw new NotFoundExecption(nameof(Category), request.ID);
            //remove
            await _repository.DeleteAsync(oldCategory.Id);
            return Unit.Value;
        }

        Task IRequestHandler<DeleteCategoryCommand>.Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
