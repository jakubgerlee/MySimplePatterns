using System;

namespace Singleton
{
    class UnsaveSingleton
    {
        private static UnsaveSingleton _instance = null; //zamiast lock, mozna od razu stworzyć obiekt + pusty konstruktor
        private int _instanceCounter = 0;

        public UnsaveSingleton()
        {
            _instanceCounter = 1;
        }

        public static UnsaveSingleton Instance
        {
            get
            {
                    if (_instance == null)
                    {
                        _instance = new UnsaveSingleton();
                    }
                    return _instance;
                
            }
        }

        public void HelloSingleton()
        {
            Console.WriteLine("Hello Singleton po raz {0} ", _instanceCounter++);
        }
    }
}
