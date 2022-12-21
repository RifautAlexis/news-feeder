using MediatR;
using Microsoft.AspNetCore.Mvc;
using NewsFeeder.Api.Endpoints.Articles;

namespace NewsFeeder.Api.Controllers
{
    [Route("[controller]")]
    public class ArticleController : ApiController
    {
        public ArticleController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<ArticleResult>>> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllArticlesRequest()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ArticleByIdResult>> GetById(int id)
        {
            var request = new ArticleByIdRequest {
                Id = id
            };
            return Ok(await _mediator.Send(request));
        }
    }
}
