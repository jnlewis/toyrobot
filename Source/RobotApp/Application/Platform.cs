using RobotApp.Application.Toys;

namespace Application
{
    public sealed class Platform
    {
        private IToy currentToy = null;

        private static readonly object locker = new object();
        private static Platform instance = null;

        private Platform()
        {
        }

        // Singleton pattern 
        public static Platform Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (locker)
                    {
                        if (instance == null)
                        {
                            instance = new Platform();
                        }
                    }
                }
                return instance;
            }
        }

        public void SetCurrentToy(IToy toy)
        {
            this.currentToy = toy;
        }

        public IToy GetCurrentToy()
        {
            return this.currentToy;
        }
    }
}
