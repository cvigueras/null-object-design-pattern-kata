namespace NullObjectDesignPattern.Console
{
    public class NullCar : ICar
    {
        private static NullCar? _instance;
        internal NullCar(){}
        public NullCar Instance => _instance ?? new NullCar();

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
