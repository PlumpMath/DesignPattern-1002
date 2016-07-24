namespace DesignPattern.CreationalPattern.Singleton.Structural
{
    /// <summary>
    ///     The 'Singleton' class
    /// </summary>
    internal class Singleton
    {
        private static Singleton instance;

        // Constructor is 'protected'
        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            return instance ?? (instance = new Singleton());
        }
    }
}