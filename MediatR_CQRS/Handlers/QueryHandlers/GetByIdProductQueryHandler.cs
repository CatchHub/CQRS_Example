using MediatR;
using Microservices.CQRS.Example.MediatR_CQRS.Queries.Requests;
using Microservices.CQRS.Example.MediatR_CQRS.Queries.Responses;
using Microservices.CQRS.Example.Models;

namespace Microservices.CQRS.Example.MediatR_CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(p => p.Id == request.ProductId);
            if (product != null)
            {
                return new GetByIdProductQueryResponse
                {
                    Id = product.Id,
                    CreateTime = product.CreateTime,
                    Name = product.Name,
                    Price = product.Price,
                    Quantity = product.Quantity
                };
            }
            return new GetByIdProductQueryResponse();
        }
    }
}
