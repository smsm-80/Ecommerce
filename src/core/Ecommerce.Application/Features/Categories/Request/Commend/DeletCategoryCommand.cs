﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Features.Categories.Request.Commend
{
    public class DeletCategoryCommand:IRequest
    {
        public int ID { get; set; }
    }
}
