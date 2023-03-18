namespace NullObjectDesignPattern.Console;

public class CarRepository
{
    private const string Seat = "Seat";
    private const string Audi = "Audi";
    private const string Volvo = "Volvo";

    public static ICar GetCar(string carName)
    {
        ICar car = carName switch
        {
            Seat => new Seat(),
            Audi => new Audi(),
            Volvo => new Volvo(),
            _ => null
        };

        return car;
    }
}