using FluentAssertions;
using NullObjectDesignPattern.Console;

namespace NullObjectDesignPattern.Test
{
    public class CarRepositoryShould
    {
        private ICar _car;
        private const string MarkSeat = "Seat";
        private const string MarkAudi = "Audi";
        private const string MarkVolvo = "Volvo";


        [Test]
        public void PrintHelloSeatWhenNameIsSeat()
        {
            var expectedResult = "Hello Seat!!";

            _car = CarRepository.GetCar(MarkSeat);
            var result = _car.SayHello();

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintHelloAudiWhenNameIsAudi()
        {
            var result = CarRepository.SayHello(MarkAudi);

            var expectedResult = "Hello Audi!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintHelloVolvoWhenNameIsVolvo()
        {
            var result = CarRepository.SayHello(MarkVolvo);

            var expectedResult = "Hello Volvo!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintSeatStartedWhenSeatStarts()
        {
            var result = CarRepository.StartCar(MarkSeat);

            var expectedResult = "Seat Started!!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintAudiStartedWhenAudiStarts()
        {
            var result = CarRepository.StartCar(MarkAudi);

            var expectedResult = "Audi Started!!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintVolvoStartedWhenVolvoStarts()
        {
            var result = CarRepository.StartCar(MarkVolvo);

            var expectedResult = "Volvo Started!!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintSeatStoppedWhenSeatStops()
        {
            var result = CarRepository.StopCar(MarkSeat);

            var expectedResult = "Seat Stopped!!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintAudiStoppedWhenAudiStops()
        {
            var result = CarRepository.StopCar(MarkAudi);

            var expectedResult = "Audi Stopped!!";

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintVolvoStoppedWhenVolvoStops()
        {
            var result = CarRepository.StopCar(MarkVolvo);

            var expectedResult = "Volvo Stopped!!";

            result.Should().Be(expectedResult);
        }
    }
}