using System;

public interface IElectric
{
    double BatteryKWh { get; set; }
    double CurrentChargePercentage { get; set; }

    void ChargeBattery()
    {
        // method definition omitted
    }
}
public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
        Console.WriteLine("Vroom!");
    }

    public virtual void Turn()
    {
        Console.WriteLine("The vehicle safely turns right");
    }

    public virtual void Stop()
    {
        Console.WriteLine("The vehicle safely comes to a complete stop");
    }
}