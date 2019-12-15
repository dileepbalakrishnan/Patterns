namespace DesignPatterns.Singleton
{
    /// <summary>
    /// This is the most common way of implementing a singleton . The double-checked locking helps to avoid
    /// unnecessary locking after the instance is created. Successive calls will just reatuen the instance and
    /// there will be no more locking. The "volatile" keyword makes sure that the instance is fully initialized
    /// before it is accessed. However, this is not required since .Net 2.0 as the lock itself is sufficient.
    /// https://en.wikipedia.org/wiki/Double-checked_locking
    /// </summary>
    public class TraditionalSingleton
    {
        private static volatile TraditionalSingleton _instance;
        private static readonly object Chrono = new object();

        private TraditionalSingleton()
        {
        }

        public static TraditionalSingleton GetInstance()
        {
            if (_instance == null)
            {
                lock (Chrono)
                {
                    if (_instance == null)
                    {
                        _instance = new TraditionalSingleton();
                    }
                }
            }
            return _instance;
        }
    }
}