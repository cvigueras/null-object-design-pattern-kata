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
            var carName = "Seat";
            var result = CarRepository.GetCarByName(carName);

            var expectedResult = "Hello Seat!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintHelloAudiWhenNameIsAudi()
        {
            var carName = "Audi";
            var result = CarRepository.GetCarByName(carName);

            var expectedResult = "Hello Audi!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintHelloVolvoWhenNameIsVolvo()
        {
            var carName = "Volvo";
            var result = CarRepository.GetCarByName(carName);

            var expectedResult = "Hello Volvo!";

            result.Should().Be(expectedResult);
        }
    }

    public class CarRepository
    {
        public static string GetCarByName(string carName)
        {
            if (carName == "Seat")
            {
                return "Hello Seat!";
            }
            if (carName == "Volvo")
            {
                return "Hello Volvo!";
            }
            return "Hello Audi!";
        }
    }
}