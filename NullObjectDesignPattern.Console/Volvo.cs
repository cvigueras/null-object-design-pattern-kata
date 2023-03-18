namespace NullObjectDesignPattern.Console;

public class Volvo : ICar
{
    private const string HelloVolvo = "Hello Volvo!!";
    private const string VolvoStarted = "Volvo Started!!";
    private const string VolvoStopped = "Volvo Stopped!!";

    public string SayHello()
    {
        return HelloVolvo;
    }

    public string StartCar()
    {
        return VolvoStarted;
    }

    public string StopCar()
    {
        return VolvoStopped;
    }
}