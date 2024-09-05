using Microservices.CQRS.Example.Manual_CQRS.Queries.Requests;
using Microservices.CQRS.Example.Manual_CQRS.Queries.Responses;
using Microservices.CQRS.Example.Models;

namespace Microservices.CQRS.Example.Manual_CQRS.Handlers.QueryHandlers
{
    public class GetAllProductsQueryHandler
    {
        public List<GetAllProductsQueryResponse> GetAllProduct(GetAllProductsQueryRequest request) 
        {
            return ApplicationDbContext.ProductList.Select(p=> new GetAllProductsQueryResponse
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
