using Api.Domain;
using Api.Endpoints.Articles;
using Api.UnitTest.Automapper;

namespace Api.UnitTests.Automapper.Articles;

[TestFixture]
public class GetArticleProfileTests : AutoMapperTestBase<Article, GetArticleResult>
{
}