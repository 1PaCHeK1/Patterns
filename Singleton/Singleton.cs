namespace Singleton
{
    public class Singleton
    {
        private static Singleton singleton;

        private readonly static object CreateLocker = new object();

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (singleton == null)
                lock (CreateLocker)
                    singleton = new Singleton();

            return singleton;
        }
    }
}