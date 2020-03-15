using System;

namespace MotorClasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ini Adalah Motor Clasic Saya!");

            motor Harley = new motor();

            Console.WriteLine("Speed saat ini : " +Harley.currentSpeed);
            Harley.go();
            Console.WriteLine("Speed saat ini : " +Harley.currentSpeed);
            Harley.turnLeft();
            Console.WriteLine("Speed saat ini : " +Harley.currentSpeed);
            Harley.go();
            Console.WriteLine("Speed saat ini : " +Harley.currentSpeed);
            Harley.turnLeft();
            Console.WriteLine("Speed saat ini : " +Harley.currentSpeed);

        }
    }
}
