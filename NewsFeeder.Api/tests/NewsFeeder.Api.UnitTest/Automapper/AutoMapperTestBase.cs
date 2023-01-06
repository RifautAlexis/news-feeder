using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using NUnit;

namespace Api.UnitTest.Automapper
{
    public class AutoMapperTestBase<TSource, TDestination> where TSource : new()
    {
        [Test]
        public void When_BasicMapping_Expect_Valid()
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<TSource, TDestination>());

            configuration.AssertConfigurationIsValid();
        }
    }
}
