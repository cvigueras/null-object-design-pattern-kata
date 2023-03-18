namespace NullObjectDesignPattern.Console;

public class CarRepository
{
    public static string SayHello(string carName)
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

    public static object StopCar(string carName)
    {
        return carName switch
        {
            "Seat" => "Seat Stopped!!",
            "Volvo" => "Volvo Stopped!!",
            _ => "Audi Stopped!!"
        };
    }

    public static ICar GetCar(string carName)
    {
        ICar car = null;
        switch (carName)
        {
            case "Seat":
                car = new Seat();
                break;
            case "Audi":
                car = new Audi();
                break;
        }

        return car;
    }
}