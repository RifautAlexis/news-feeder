using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;

namespace NewsFeeder.Api.UnitTest.Endpoints.Articles.GetAll
{
    public class GetAllTests
    {
        private readonly HttpClient _httpClient;

        [SetUp]
        public void Setup()
        {
            _httpClient = new HttpClient();
        }

        [Test]
        public void GetAllTests()
        {

        }
    }
}
