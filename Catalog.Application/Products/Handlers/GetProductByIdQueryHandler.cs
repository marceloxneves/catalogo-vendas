using Catalog.Application.Products.Queries;
using Catalog.Domain.Entities;
using Catalog.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.Application.Products.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IProductRepository _productRepository;
        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Handle(GetProductByIdQuery request,
             CancellationToken cancellationToken)
        {
            return await _productRepository.GetByIdAsync(request.Id);
        }
    }
}
