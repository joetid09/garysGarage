using System;

namespace garysGarage
{
    class Program
    {
        static void Main(string[] args)
        {

            Cessna myCessna = new Cessna
            {
                MainColor = "Red",
                MaximumOccupancy = "Three"
            };
            Zero myZero = new Zero
            {
                MainColor = "Blue",
                MaximumOccupancy = "Eight"
            };
            Tesla myTesla = new Tesla
            {
                MainColor = "Teal",
                MaximumOccupancy = "Four"
            };
            Ram myRam = new Ram
            {
                MainColor = "Maroon",
                MaximumOccupancy = "Five"
            };

            myCessna.Drive();
            myCessna.Turn();
            myCessna.Stop();

            myTesla.Drive();
            myTesla.Turn();
            myTesla.Stop();

            myRam.Drive();
            myRam.Turn();
            myRam.Stop();

            myZero.Drive();
            myZero.Turn();
            myZero.Stop();
        }
    }
}
