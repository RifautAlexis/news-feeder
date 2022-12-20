using Ardalis.ApiEndpoints;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.JsonPatch.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsFeeder.Api.DataAccess;
using Swashbuckle.AspNetCore.Annotations;

namespace NewsFeeder.Api.Endpoints.Articles;

public class GetById : EndpointBaseAsync
    .WithRequest<ArticleByIdRequest>
    .WithActionResult<IEnumerable<ArticleByIdResult>>
{
    private readonly AppDbContext _appDbContext;
    private readonly AutoMapper.IConfigurationProvider _mappings;

    public GetById(AppDbContext appDbContext, AutoMapper.IConfigurationProvider mappings)
    {
        _appDbContext = appDbContext;
        _mappings = mappings;
    }

    [HttpGet("/[namespace]/{id}")]
    [SwaggerOperation(
        Summary = "Get an Article by his Id",
        Description = "Get an Article by his Id",
        OperationId = "Article.GetById",
        Tags =new[] {"Article"})]
    public override async Task<ActionResult<IEnumerable<ArticleByIdResult>>> HandleAsync([FromRoute]ArticleByIdRequest request, CancellationToken cancellationToken = default)
    {
        return await _appDbContext
            .Articles
            .Where(e => e.Id == request.Id)
            .ProjectTo<ArticleByIdResult>(_mappings)
            .ToListAsync(cancellationToken);
    }
}
