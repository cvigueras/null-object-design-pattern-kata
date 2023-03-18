namespace NullObjectDesignPattern.Console;

public class Seat : ICar
{
    private const string HelloSeat = "Hello Seat!!";
    private const string SeatStarted = "Seat Started!!";
    private const string SeatStopped = "Seat Stopped!!";

    public string SayHello()
    {
        return HelloSeat;
    }

    public string StartCar()
    {
        return SeatStarted;
    }

    public string StopCar()
    {
        return SeatStopped;
    }
}