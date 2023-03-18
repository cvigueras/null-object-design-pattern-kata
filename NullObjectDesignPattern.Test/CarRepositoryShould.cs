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
            var expectedResult = "Hello Audi!!";

            _car = CarRepository.GetCar(MarkAudi);
            var result = _car.SayHello();


            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintHelloVolvoWhenNameIsVolvo()
        {
            var expectedResult = "Hello Volvo!!";

            _car = CarRepository.GetCar(MarkVolvo);
            var result = _car.SayHello();


            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintSeatStartedWhenSeatStarts()
        {
            var expectedResult = "Seat Started!!";

            _car = CarRepository.GetCar(MarkSeat);
            var result = _car.StartCar();

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintAudiStartedWhenAudiStarts()
        {
            var expectedResult = "Audi Started!!";

            _car = CarRepository.GetCar(MarkAudi);
            var result = _car.StartCar();

            result.Should().Be(expectedResult);
        }

        [Test]
        public void PrintVolvoStartedWhenVolvoStarts()
        {
            var expectedResult = "Volvo Started!!";

            _car = CarRepository.GetCar(MarkVolvo);
            var result = _car.StartCar();

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