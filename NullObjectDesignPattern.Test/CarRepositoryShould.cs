using FluentAssertions;

namespace NullObjectDesignPattern.Test
{
    public class CarRepositoryShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PrintHelloSeatWhenNameIsSeat()
        {
            var result = CarRepository.GetCarByName();

            var expectedResult = "Hello Seat!";

            result.Should().Be(expectedResult);
        }
    }

    public class CarRepository
    {
        public static string GetCarByName()
        {
            return "Hello Seat!";
        }
    }
}