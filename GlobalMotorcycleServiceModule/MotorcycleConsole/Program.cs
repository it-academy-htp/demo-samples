using GlobalMotorcycleServiceModule;
using System;

namespace MotorcycleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MotorcycleService service = new MotorcycleService();
            MyConsoleMotorcycle myConsoleMotorcycle = new MyConsoleMotorcycle("Honda");

            //Let's Drive
            myConsoleMotorcycle.StartEngine();
            myConsoleMotorcycle.Move(1_000);
            myConsoleMotorcycle.Move(5_000);
            myConsoleMotorcycle.StopEngine();
            myConsoleMotorcycle = null;
            service = null;

            //Let's Drive one more time
            service = new MotorcycleService();
            myConsoleMotorcycle = new MyConsoleMotorcycle("Honda");
            myConsoleMotorcycle.StartEngine();
            myConsoleMotorcycle.Move(1_000);
            myConsoleMotorcycle.Move(5_000);
            myConsoleMotorcycle.StopEngine();
            myConsoleMotorcycle = null;
            service = null;

            //Let's Drive one more time
            service = new MotorcycleService();
            myConsoleMotorcycle = new MyConsoleMotorcycle("Honda");
            myConsoleMotorcycle.StartEngine();
        }

        #region CustomLogic

        static void GoToService(int totalDistance)
        {
            Console.WriteLine($"Time to go moto Service. Current Distance of your bike: {totalDistance}");
        }

        #endregion
    }
}
