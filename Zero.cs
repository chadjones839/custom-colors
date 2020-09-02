using System;

namespace CustomColors
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you.Yeeeeeeooooooowwwwww!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero pops a wheelie and attempts a {direction} turn");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero Endo's into a full stop.");
        }
    }

}