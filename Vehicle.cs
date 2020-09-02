using System;

namespace CustomColors
{

    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine("You always turn left 4,000 times on a SUNDAY!!");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Come to a screeching halt.");
        }
    }
}