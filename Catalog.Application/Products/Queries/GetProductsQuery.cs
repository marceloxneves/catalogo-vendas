using Catalog.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Catalog.Application.Products.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
