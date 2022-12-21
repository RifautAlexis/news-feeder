using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NewsFeeder.Api.DataAccess;

namespace NewsFeeder.Api.Endpoints.Articles;

public class GetAll : IRequestHandler<GetAllArticlesRequest, IEnumerable<ArticleResult>>
{
    private readonly AppDbContext _appDbContext;
    private readonly AutoMapper.IConfigurationProvider _mappings;

    public GetAll(AppDbContext appDbContext, AutoMapper.IConfigurationProvider mappings)
    {
        _appDbContext = appDbContext;
        _mappings = mappings;
    }

    public async Task<IEnumerable<ArticleResult>> Handle(GetAllArticlesRequest request, CancellationToken cancellationToken)
    {
        return await _appDbContext
            .Articles
            .ProjectTo<ArticleResult>(_mappings)
            .ToListAsync(cancellationToken);
    }
}
