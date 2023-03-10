using AutoMapper.QueryableExtensions;
using Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Articles.GetArticle;

public class GetById : IRequestHandler<GetArticleRequest, GetArticleResult>
{
    private readonly AppDbContext _appDbContext;
    private readonly AutoMapper.IConfigurationProvider _mappings;

    public GetById(AppDbContext appDbContext, AutoMapper.IConfigurationProvider mappings)
    {
        _appDbContext = appDbContext;
        _mappings = mappings;
    }

    public async Task<GetArticleResult> Handle(GetArticleRequest request, CancellationToken cancellationToken)
    {
        return await _appDbContext
            .Articles
            .Where(e => e.Id == request.Id)
            .ProjectTo<GetArticleResult>(_mappings)
            .FirstAsync(cancellationToken);
    }
}