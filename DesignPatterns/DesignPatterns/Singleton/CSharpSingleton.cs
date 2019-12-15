namespace DesignPatterns.Singleton
{
    /// <summary>
    /// This class makes use of the fact that static initilizers are threadsafe  - only one thread is allowed
    /// to be in a static intializer at a time. The readonly keyword makes sure that no further write is possible.
    /// </summary>
    public class CSharpSingleton
    {
        private static readonly CSharpSingleton _instance = new CSharpSingleton();

        private CSharpSingleton()
        {
        }

        public CSharpSingleton Instance => _instance;
    }
}