using MediatR;
using Microsoft.AspNetCore.Mvc;
using Api.Endpoints.Articles;

namespace Api.Controllers
{
    [Route("[controller]")]
    public class ArticleController : ApiController
    {
        public ArticleController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<GetArticlesResult>>> GetAll()
        {
            return Ok(await _mediator.Send(new GetArticlesRequest()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetArticleResult>> GetById(int id)
        {
            var request = new GetArticleRequest {
                Id = id
            };
            return Ok(await _mediator.Send(request));
        }
    }
}
