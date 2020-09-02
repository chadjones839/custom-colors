using System;

namespace CustomColors
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.MainColor = "Midnight Blue";
            Zero fxs2 = new Zero();
            fxs2.MainColor = "Black";
            Tesla modelS = new Tesla();
            modelS.MainColor = "Burgundy";

            Ram biggin = new Ram();
            biggin.MainColor = "Silver";
            Cessna mx410 = new Cessna();
            mx410.MainColor = "White";

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
            Console.WriteLine();
            fxs2.Drive();
            fxs2.Turn("left");
            fxs2.Stop();
            Console.WriteLine();
            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            Console.WriteLine();
            biggin.Drive();
            biggin.Turn("left");
            biggin.Stop();
            Console.WriteLine();
            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();
        }
    }
}