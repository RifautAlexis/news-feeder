using FluentAssertions;
using NUnit.Framework;
using Api.Domain;
using Api.Endpoints.Articles;

namespace Api.IntegrationTests.Handlers.Articles;

using static Testing;

public class GetByIdTests : BaseTestFixture
{
    [Test]
    public async Task ShouldReturnAllArticles()
    {
        // Arrenge
        var user = new User
        {
            Email = "test.name@gmail.com",
            Name = "Test name",
            Role = Role.Admin
        };
        await AddAsync(user);

        var title = "Title 01";
        var article = new Article
        {
            Title = title,
            Content = "Content 01",
            AuthorId = user.Id
        };
        await AddAsync(article);

        var query = new GetArticleRequest
        {
            Id = article.Id
        };

        // Act
        var result = await SendAsync(query);

        // Assert
        result.Title.Should().Be(title);
    }
}
