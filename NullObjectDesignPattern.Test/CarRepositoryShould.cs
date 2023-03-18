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


        [TestCase(MarkSeat, "Hello Seat!!")]
        [TestCase(MarkAudi, "Hello Audi!!")]
        [TestCase(MarkVolvo, "Hello Volvo!!")]
        public void PrintHelloCarWhenGetCar(string input, string expectedResult)
        {
            _car = CarRepository.GetCar(input);
            var result = _car.SayHello();

            result.Should().Be(expectedResult);
        }

        [TestCase(MarkSeat, "Seat Started!!")]
        [TestCase(MarkAudi, "Audi Started!!")]
        [TestCase(MarkVolvo, "Volvo Started!!")]
        public void PrintCarStartedWhenStartCar(string input, string expectedResult)
        {
            _car = CarRepository.GetCar(input);
            var result = _car.StartCar();

            result.Should().Be(expectedResult);
        }

        [TestCase(MarkSeat, "Seat Stopped!!")]
        [TestCase(MarkAudi, "Audi Stopped!!")]
        [TestCase(MarkVolvo, "Volvo Stopped!!")]
        public void PrintCarStoppedWhenStopCar(string input, string expectedResult)
        {
            _car = CarRepository.GetCar(input);
            var result = _car.StopCar();

            result.Should().Be(expectedResult);
        }
    }
}