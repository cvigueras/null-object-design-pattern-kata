namespace NullObjectDesignPattern.Console;

public class Audi : ICar
{
    public string SayHello()
    {
        return "Hello Audi!!";
    }

    public string StartCar()
    {
        throw new NotImplementedException();
    }
}