using System;

namespace CustomColors
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla putters by you. Mmmmmmmm!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla executes a {direction}-hand turn. Don't worry, they're going to tell you all about how smooth it was compared to a gas vehicle.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla silently stops as if it had never moved!");
        }
    }
}