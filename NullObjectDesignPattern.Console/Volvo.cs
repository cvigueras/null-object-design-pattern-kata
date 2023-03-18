namespace NullObjectDesignPattern.Console;

public class Volvo : ICar
{
    public string SayHello()
    {
        return "Hello Volvo!!";
    }

    public string StartCar()
    {
        return "Volvo Started!!";
    }

    public string StopCar()
    {
        throw new NotImplementedException();
    }
}