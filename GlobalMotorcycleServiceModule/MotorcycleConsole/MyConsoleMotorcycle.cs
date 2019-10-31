using GlobalMotorcycleServiceModule;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotorcycleConsole
{
    

    sealed class MyConsoleMotorcycle
    {
        public string Model { get; set; }
        public static int Odometer { get; set; }

        public int DailyDistance { get; set; }

        public MyConsoleMotorcycle()
        {
        }

        public MyConsoleMotorcycle(string name)
        {
            Model = name;
        }

        public void StartEngine()
        {
            Console.WriteLine();
            Console.WriteLine("Engine started.");
        }

        public void Move(int distance)
        {
            DailyDistance += distance;
            Console.WriteLine($"Move to {distance}km.");
        }

        public void StopEngine()
        {
            Odometer += DailyDistance;
            MotorcycleService.TotalDistance += Odometer;
            Console.WriteLine("Engine stopped.");
            Console.WriteLine($"Total distance: {Odometer}km.");
        }
    }
}
