using Application.Articles.GetArticles;
using Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace Api.IntegrationTests.Handlers.Articles;

using static Testing;

public class GetAllTests : BaseTestFixture
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

        await AddRangeAsync(new List<Article> {
        new Article {
            Title = "Title 01",
            Content = "Content 01",
            AuthorId = user.Id
        },
            new Article {
            Title = "Title 02",
            Content = "Content 02",
            AuthorId = user.Id
        },
            new Article {
            Title = "Title 03",
            Content = "Content 03",
            AuthorId = user.Id
        },
        });

        var query = new GetArticlesRequest();

        // Act
        var result = await SendAsync(query);

        // Assert
        result.Should().HaveCount(3);
    }
}