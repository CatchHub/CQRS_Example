using MediatR;
using Microservices.CQRS.Example.MediatR_CQRS.Commands.Responses;
namespace Microservices.CQRS.Example.MediatR_CQRS.Commands.Requests
{
    public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
    {
        public Guid ProductId { get; set; }
    }
}
