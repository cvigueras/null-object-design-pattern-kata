namespace NullObjectDesignPattern.Console;

public class CarRepository
{
    public static string GetCarByName(string carName)
    {
        return carName == "Seat" ? "Hello Seat!" : carName == "Volvo" ? "Hello Volvo!" : "Hello Audi!";
    }

    public static object StartCar(object carName)
    {
        if (carName == "Seat")
        {
            return "Seat Started!!";
        }
        if (carName == "Volvo")
        {
            return "Volvo Started!!";
        }

        return "Audi Started!!";
    }
}