using MediatR;
using Microservices.CQRS.Example.MediatR_CQRS.Queries.Requests;
using Microservices.CQRS.Example.MediatR_CQRS.Queries.Responses;
using Microservices.CQRS.Example.Models;

namespace Microservices.CQRS.Example.MediatR_CQRS.Handlers.QueryHandlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, List<GetAllProductsQueryResponse>>
    {
        public async Task<List<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            return ApplicationDbContext.ProductList.Select(p => new GetAllProductsQueryResponse
            {
                CreateTime = p.CreateTime,
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Quantity = p.Quantity,
            }).ToList();
        }
    }
}
