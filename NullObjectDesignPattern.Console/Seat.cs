namespace NullObjectDesignPattern.Console;

public class Seat : ICar
{
    public string SayHello()
    {
        return "Hello Seat!!";
    }

    public string StartCar()
    {
        return "Seat Started!!";
    }

    public string StopCar()
    {
        return "Seat Stopped!!";
    }
}