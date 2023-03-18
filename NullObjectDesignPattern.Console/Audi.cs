namespace NullObjectDesignPattern.Console;

public class Audi : ICar
{
    private const string HelloAudi = "Hello Audi!!";
    private const string AudiStarted = "Audi Started!!";
    private const string AudiStopped = "Audi Stopped!!";

    public string SayHello()
    {
        return HelloAudi;
    }

    public string StartCar()
    {
        return AudiStarted;
    }

    public string StopCar()
    {
        return AudiStopped;
    }
}