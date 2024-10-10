using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Categories.Request.Query
{
    public class GetCatgoryDetailsRequest:IRequest<CategoryDTO>
    {
        public int ID { get; set; }
    }
}
