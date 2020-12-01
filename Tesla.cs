using System;

public class Tesla : Vehicle, IElectric  // Electric car
{
    public double BatteryKWh { get; set; } = 50;

    public double CurrentChargePercentage { get; set; } = 0;


    public void ChargeBattery()
    {
        CurrentChargePercentage = 100;
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla quietly speeds away");
    }
}