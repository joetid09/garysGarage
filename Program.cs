using System;

namespace garysGarage
{
    class Program
    {
        static void Main(string[] args)
        {

            Cessna myCessna = new Cessna
            {
                MainColor = "red"
            };

            Console.WriteLine($"{myCessna.MainColor}");
        }
    }
}
