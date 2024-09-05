using Microservices.CQRS.Example.Manual_CQRS.Commands.Requests;
using Microservices.CQRS.Example.Manual_CQRS.Commands.Responses;
using Microservices.CQRS.Example.Models;

namespace Microservices.CQRS.Example.Manual_CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler
    {
        public CreateProductCommandResponse CreateProduct(CreateProductCommandRequest request)
        {
            var id = Guid.NewGuid();
            ApplicationDbContext.ProductList.Add(new()
            {
                Id = id,
                Name = request.Name,
                CreateTime = DateTime.Now,
                Price = request.Price,
                Quantity = request.Quantity
            });
            return new CreateProductCommandResponse
            {
                ProductId = id,
                IsSuccess = true
            };
        }
    }
}
