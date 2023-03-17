namespace NullObjectDesignPattern.Console;

public class CarRepository
{
    public static string GetCarByName(string carName)
    {
        return carName switch
        {
            "Seat" => "Hello Seat!",
            "Volvo" => "Hello Volvo!",
            _ => "Hello Audi!"
        };
    }

    public static object StartCar(object carName)
    {
        return carName switch
        {
            "Seat" => "Seat Started!!",
            "Volvo" => "Volvo Started!!",
            _ => "Audi Started!!"
        };
    }

    public static object StopCar(string carname)
    {
        return carname switch
        {
            "Seat" => "Seat Stopped!!",
            "Volvo" => "Volvo Stopped!!",
            _ => "Audi Stopped!!"
        };
    }
}