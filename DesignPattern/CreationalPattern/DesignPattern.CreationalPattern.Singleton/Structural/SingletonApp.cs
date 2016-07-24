using System;

namespace DesignPattern.CreationalPattern.Singleton.Structural
{
    /// <summary>
    ///     MainApp startup class for Structural
    ///     Singleton Design Pattern.
    /// </summary>
    public  static  class SingletonApp
    {
        /// <summary>
        ///     Entry point into console application.
        /// </summary>
        public static void Execute()
        {
            // Constructor is protected -- cannot use new
            var s1 = Singleton.Instance();
            var s2 = Singleton.Instance();

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}