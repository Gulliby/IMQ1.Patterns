using System;

namespace IMQ1.Patterns.Examples
{
    public sealed class Singleton
    {
        private static volatile Singleton instance;
        private static object syncRoot = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }

                return instance;
            }
        }
        
        public void ValeraTiGde()
        {
            Console.WriteLine("Valera ti gde?");
        }
    }
}
