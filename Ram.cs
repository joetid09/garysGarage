using System;

public class Ram : Vehicle   // Gas powered truck
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram hauls it out of there, HARUMPPHH");
    }
}