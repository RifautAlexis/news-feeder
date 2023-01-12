using Api.UnitTest.Automapper;
using Application.Articles.GetArticle;
using Domain.Entities;

namespace Api.UnitTests.Automapper.Articles;

[TestFixture]
public class GetArticleProfileTests : AutoMapperTestBase<Article, GetArticleResult>
{
}