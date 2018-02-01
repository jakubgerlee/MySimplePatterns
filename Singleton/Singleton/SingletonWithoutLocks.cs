using System;

namespace Singleton
{
    public sealed class SingletonWithoutLocks
    {
        private static readonly SingletonWithoutLocks m_oInstance = new SingletonWithoutLocks();
        private int m_nCounter = 0;

        static SingletonWithoutLocks()
        {
        }

        public static SingletonWithoutLocks Instance
        {
            get
            {
                return m_oInstance;
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Hello World po raz {0}!", m_nCounter++);
        }

        private SingletonWithoutLocks()
        {
            m_nCounter = 1;
        }
    }
}
//http://www.altcontroldelete.pl/artykuly/konstrukcyjny-wzorzec-projektowy-singleton-implementacja-w-c-/