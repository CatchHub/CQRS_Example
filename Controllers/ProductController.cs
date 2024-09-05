using Microservices.CQRS.Example.Manual_CQRS.Commands.Requests;
using Microservices.CQRS.Example.Manual_CQRS.Handlers.CommandHandlers;
using Microservices.CQRS.Example.Manual_CQRS.Handlers.QueryHandlers;
using Microservices.CQRS.Example.Manual_CQRS.Queries.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.CQRS.Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(
        CreateProductCommandHandler createProductCommandHandler,
        DeleteProductCommandHandler deleteProductCommandHandler,
        GetAllProductsQueryHandler getAllProductsQueryHandler,
        GetByIdProductQueryHandler getByIdProductQueryHandler) : ControllerBase
    {

        [HttpGet]
        public IActionResult Get([FromQuery]GetAllProductsQueryRequest request) 
            => Ok(getAllProductsQueryHandler.GetAllProduct(request));
        [HttpGet("{ProductId}")]
        public IActionResult Get([FromRoute]GetByIdProductQueryRequest request) 
            => Ok(getByIdProductQueryHandler.GetByIdProduct(request));
        [HttpPost]
        public IActionResult Post([FromBody] CreateProductCommandRequest request) 
            => Ok(createProductCommandHandler.CreateProduct(request));
        [HttpDelete("{ProductId}")]
        public IActionResult Delete([FromRoute] DeleteProductCommandRequest request) 
            => Ok(deleteProductCommandHandler.DeleteProduct(request));
    }
}
