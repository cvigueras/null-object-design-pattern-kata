namespace NullObjectDesignPattern.Console
{
    public class NullCar : ICar
    {
        public NullCar Instance => new NullCar();

        public string SayHello()
        {
            return string.Empty;
        }

        public string StartCar()
        {
            return string.Empty;
        }

        public string StopCar()
        {
            return string.Empty;
        }
    }
}
