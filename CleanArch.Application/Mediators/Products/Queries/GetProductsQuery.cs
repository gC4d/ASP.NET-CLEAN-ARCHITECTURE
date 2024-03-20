using CleanArch.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Mediators.Products.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
