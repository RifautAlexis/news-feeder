using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace NewsFeeder.Api.Controllers
{
    public abstract class ApiController : ControllerBase
    {
        protected readonly IMediator _mediator;

        protected ApiController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
