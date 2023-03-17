namespace NullObjectDesignPattern.Console;

public class CarRepository
{
    public static string GetCarByName(string carName)
    {
        return carName == "Seat" ? "Hello Seat!" : carName == "Volvo" ? "Hello Volvo!" : "Hello Audi!";
    }
}