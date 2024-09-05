using Microservices.CQRS.Example.Manual_CQRS.Queries.Requests;
using Microservices.CQRS.Example.Manual_CQRS.Queries.Responses;
using Microservices.CQRS.Example.Models;

namespace Microservices.CQRS.Example.Manual_CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler
    {

        public GetByIdProductQueryResponse GetByIdProduct(GetByIdProductQueryRequest request)
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
