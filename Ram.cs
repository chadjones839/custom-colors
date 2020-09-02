using System;

namespace CustomColors
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram growls by you. RRrrrrrummmbbble!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The lumbering waste of metal carefully turns {direction} so that it doesn't fall apart from shoddy craftsmanship.");
        }
        public override void Stop()
        {
            Console.WriteLine("The Rams brakes screech to a halt");
        }
    }

}