namespace NullObjectDesignPattern.Console;

public class Audi : ICar
{
    public string SayHello()
    {
        return "Hello Audi!!";
    }

    public string StartCar()
    {
        return "Audi Started!!";
    }
}