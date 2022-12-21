using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NewsFeeder.Api.DataAccess;

namespace NewsFeeder.Api.Endpoints.Articles;

public class GetById : IRequestHandler<ArticleByIdRequest, ArticleByIdResult>
{
    private readonly AppDbContext _appDbContext;
    private readonly AutoMapper.IConfigurationProvider _mappings;

    public GetById(AppDbContext appDbContext, AutoMapper.IConfigurationProvider mappings)
    {
        _appDbContext = appDbContext;
        _mappings = mappings;
    }

    public async Task<ArticleByIdResult> Handle(ArticleByIdRequest request, CancellationToken cancellationToken)
    {
        return await _appDbContext
            .Articles
            .Where(e => e.Id == request.Id)
            .ProjectTo<ArticleByIdResult>(_mappings)
            .FirstAsync(cancellationToken);
    }
}
