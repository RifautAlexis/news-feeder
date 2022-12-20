using Ardalis.ApiEndpoints;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using NewsFeeder.Api.DataAccess;
using Swashbuckle.AspNetCore.Annotations;

namespace NewsFeeder.Api.Endpoints.Articles;

public class GetAll : EndpointBaseSync
    .WithoutRequest
    .WithActionResult<IQueryable<ArticleResult>>
{
    private readonly AppDbContext _appDbContext;
    private readonly AutoMapper.IConfigurationProvider _mappings;

    public GetAll(AppDbContext appDbContext, AutoMapper.IConfigurationProvider mappings)
    {
        _appDbContext = appDbContext;
        _mappings = mappings;
    }

    [HttpGet("/[namespace]")]
    [SwaggerOperation(
        Summary = "Get all Articles",
        Description = "Get all Articles",
        OperationId = "Article.Get",
        Tags = new[] { "Article" })]
    public override ActionResult<IQueryable<ArticleResult>> Handle()
    {
        return Ok(_appDbContext
            .Articles
            .ProjectTo<ArticleResult>(_mappings));
    }
}
