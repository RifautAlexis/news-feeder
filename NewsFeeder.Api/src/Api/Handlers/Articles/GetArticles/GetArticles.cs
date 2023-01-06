using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Api.DataAccess;

namespace Api.Endpoints.Articles;

public class GetArticles : IRequestHandler<GetArticlesRequest, IEnumerable<GetArticlesResult>>
{
    private readonly AppDbContext _appDbContext;
    private readonly AutoMapper.IConfigurationProvider _mappings;

    public GetArticles(AppDbContext appDbContext, AutoMapper.IConfigurationProvider mappings)
    {
        _appDbContext = appDbContext;
        _mappings = mappings;
    }

    public async Task<IEnumerable<GetArticlesResult>> Handle(GetArticlesRequest request, CancellationToken cancellationToken)
    {
        return await _appDbContext
            .Articles
            .ProjectTo<GetArticlesResult>(_mappings)
            .ToListAsync(cancellationToken);
    }
}
