using FluentAssertions;
using NullObjectDesignPattern.Console;

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

        [Test]
        public void PrintSeatStartedWhenSeatStarts()
        {
            var carname = "Seat";
            var result = CarRepository.StartCar(carname);
            var expectedResult = "Seat Started!!";
            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintAudiStartedWhenAudiStarts()
        {
            var carname = "Audi";
            var result = CarRepository.StartCar(carname);
            var expectedResult = "Audi Started!!";
            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintVolvoStartedWhenVolvoStarts()
        {
            var carname = "Volvo";
            var result = CarRepository.StartCar(carname);
            var expectedResult = "Volvo Started!!";
            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintSeatStoppedWhenSeatStops()
        {
            var carname = "Seat";
            var result = CarRepository.StopCar(carname);
            var expectedResult = "Seat Stopped!!";
            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintAudiStoppedWhenAudiStops()
        {
            var carname = "Audi";
            var result = CarRepository.StopCar(carname);
            var expectedResult = "Audi Stopped!!";
            result.Should().Be(expectedResult);
        }
    }
}