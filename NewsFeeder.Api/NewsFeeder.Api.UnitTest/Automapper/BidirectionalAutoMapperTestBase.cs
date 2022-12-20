using AutoMapper;

namespace NewsFeeder.Api.UnitTest.Automapper
{
    public class BidirectionalAutoMapperTestBase<TSource, TDestination> : AutoMapperTestBase<TSource, TDestination> where TSource : new() where TDestination : new()
    {
        [Test]
        public void When_BiDirectionalBasicMapping_Expect_Valid()
        {
            var configuration = new MapperConfiguration(cfg => cfg.CreateMap<TDestination, TSource>());

            configuration.AssertConfigurationIsValid();
        }
    }
}
