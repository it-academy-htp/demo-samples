using System;

namespace GlobalMotorcycleServiceModule
{
    public delegate void MotoServiceDelegate(int totalDistance);

    public class MotorcycleService
    {
        public static int TotalDistance { get; set; }

        public MotorcycleService()
        {
            CheckDistance();
        }

        void CheckDistance()
        {
            if (TotalDistance >= 10_000)
            {
                NotifyAboutService();
            }
        }

        private void NotifyAboutService()
        {
            //TODO: invoke notifucation to appropriate motocycle
            throw new NotImplementedException();
        }
    }
}
