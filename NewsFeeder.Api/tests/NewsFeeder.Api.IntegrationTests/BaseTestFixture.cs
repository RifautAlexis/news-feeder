using NUnit.Framework;

namespace Api.IntegrationTests;

using static Testing;

[TestFixture]
public abstract class BaseTestFixture
{
    [SetUp]
    public void TestSetUp()
    {
        ResetState();
    }
}