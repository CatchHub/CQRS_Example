using MediatR;
using Microservices.CQRS.Example.MediatR_CQRS.Queries.Responses;

namespace Microservices.CQRS.Example.MediatR_CQRS.Queries.Requests
{
    public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
    {
        public Guid ProductId { get; set; }
    }
}
