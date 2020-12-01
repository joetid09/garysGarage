using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
              };

            Console.WriteLine("Electric Vehicles");

            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev} has a charge of {ev.CurrentChargePercentage}");
            }

            foreach (IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"The {ev } has been charged up to {ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGassy> gasVehicles = new List<IGassy>() {
                ram, cessna150
              };

            Console.WriteLine("Gas Vehicles");
            foreach (IGassy gv in gasVehicles)
            {
                Console.WriteLine($"{gv} currently has {gv.CurrentTankPercentage} points");
            }

            foreach (IGassy gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGassy gv in gasVehicles)
            {
                Console.WriteLine($"The {gv} has been refueled to {gv.CurrentTankPercentage} gas points");
            }
        }
    }
}