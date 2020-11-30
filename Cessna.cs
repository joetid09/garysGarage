using System;

public class Cessna : Vehicle  // Propellor light aircraft
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
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