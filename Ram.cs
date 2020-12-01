using System;

public class Ram : Vehicle, IGassy   // Gas powered truck
{
    public double FuelCapacity { get; set; }

    public double CurrentTankPercentage { get; set; } = 10;


    public void RefuelTank()
    {
        CurrentTankPercentage = 100;
    }


    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram hauls it out of there, HARUMPPHH");
    }

    public override void Stop()
    {
        Console.WriteLine("The Ram skids to a hault");
    }
}