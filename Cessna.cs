using System;

public class Cessna : Vehicle, IGassy  // Propellor light aircraft
{
    public double FuelCapacity { get; set; }


    public double CurrentTankPercentage { get; set; } = 25;

    public void RefuelTank()
    {
        CurrentTankPercentage = 100;
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Cessna flashes like a hurricane, ZOOM");
    }

    public override void Turn()
    {
        Console.WriteLine("The Cessna taxis to the terminal after landing");
    }
}