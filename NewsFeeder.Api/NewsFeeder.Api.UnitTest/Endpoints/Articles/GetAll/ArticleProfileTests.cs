using NewsFeeder.Api.Domain;
using NewsFeeder.Api.Endpoints.Articles;
using NewsFeeder.Api.UnitTest.Automapper;

namespace NewsFeeder.Api.UnitTest.Endpoints.Articles.GetAll
{
    [TestFixture]
    public class ArticleProfileTests : AutoMapperTestBase<Article, ArticleResult>
    {
    }
}
