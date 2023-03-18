namespace NullObjectDesignPattern.Console;

public class CarRepository
{
    private const string Seat = "Seat";
    private const string Audi = "Audi";
    private const string Volvo = "Volvo";

    public static ICar? GetCar(string carName)
    {
        ICar? car = new NullCar().Instance;
        if (carName == Seat)
            car = new Seat();
        else if (carName == Audi)
            car = new Audi();
        else if (carName == Volvo)
            car = new Volvo();
        return car;
    }
}