namespace NullObjectDesignPattern.Console;

public class Volvo : ICar
{
    public string SayHello()
    {
        return "Hello Volvo!!";
    }

    public string StartCar()
    {
        throw new NotImplementedException();
    }
}