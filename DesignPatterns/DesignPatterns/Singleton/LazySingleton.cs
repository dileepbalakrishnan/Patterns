using System;

namespace DesignPatterns.Singleton
{
    /// <summary>
    ///     A fully lazy and thread-safe implementation for .Net 4.0 and above.
    /// </summary>
    public class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _instance =
            new Lazy<LazySingleton>(() => new LazySingleton(), true);

        private LazySingleton()
        {
        }

        public LazySingleton Instance => _instance.Value;
    }
}