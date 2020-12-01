using System;

public class Zero : Vehicle, IElectric  // Electric motorcycle
{
    public double BatteryKWh { get; set; } = 100;

    public double CurrentChargePercentage { get; set; } = 25;

    public void ChargeBattery()
    {
        CurrentChargePercentage = 100;
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero Zips Away");
    }
}