using FluentAssertions;
using NullObjectDesignPattern.Console;

namespace NullObjectDesignPattern.Test
{
    public class CarRepositoryShould
    {
        private const string Seat = "Seat";
        private const string Audi = "Audi";
        private const string Volvo = "Volvo";


        [Test]
        public void PrintHelloSeatWhenNameIsSeat()
        {
            var result = CarRepository.GetCarByName(Seat);

            var expectedResult = "Hello Seat!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintHelloAudiWhenNameIsAudi()
        {
            var result = CarRepository.GetCarByName(Audi);

            var expectedResult = "Hello Audi!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintHelloVolvoWhenNameIsVolvo()
        {
            var result = CarRepository.GetCarByName(Volvo);

            var expectedResult = "Hello Volvo!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintSeatStartedWhenSeatStarts()
        {
            var result = CarRepository.StartCar(Seat);

            var expectedResult = "Seat Started!!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintAudiStartedWhenAudiStarts()
        {
            var result = CarRepository.StartCar(Audi);

            var expectedResult = "Audi Started!!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintVolvoStartedWhenVolvoStarts()
        {
            var result = CarRepository.StartCar(Volvo);

            var expectedResult = "Volvo Started!!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintSeatStoppedWhenSeatStops()
        {
            var result = CarRepository.StopCar(Seat);

            var expectedResult = "Seat Stopped!!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintAudiStoppedWhenAudiStops()
        {
            var result = CarRepository.StopCar(Audi);

            var expectedResult = "Audi Stopped!!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintVolvoStoppedWhenVolvoStops()
        {
            var result = CarRepository.StopCar(Volvo);

            var expectedResult = "Volvo Stopped!!";

            result.Should().Be(expectedResult);
        }
    }
}