using MediatR;
using Microservices.CQRS.Example.MediatR_CQRS.Commands.Requests;
using Microservices.CQRS.Example.MediatR_CQRS.Commands.Responses;
using Microservices.CQRS.Example.Models;

namespace Microservices.CQRS.Example.MediatR_CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = ApplicationDbContext.ProductList.FirstOrDefault(p => p.Id == request.ProductId);
            if (product != null)
            {
                ApplicationDbContext.ProductList.Remove(product);
                return new DeleteProductCommandResponse
                {
                    IsSuccess = true,
                };
            }
            return new DeleteProductCommandResponse
            {
                IsSuccess = false,
            };
        }

    }
}
