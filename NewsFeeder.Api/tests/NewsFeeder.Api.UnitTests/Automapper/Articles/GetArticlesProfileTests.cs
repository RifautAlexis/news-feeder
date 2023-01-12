using Api.UnitTest.Automapper;
using Application.Articles.GetArticles;
using Domain.Entities;

namespace Api.UnitTests.Automapper.Articles;

[TestFixture]
public class GetArticlesProfileTests : AutoMapperTestBase<Article, GetArticlesResult>
{
}