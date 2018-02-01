using System;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int nCounter = 0; nCounter < 10; ++nCounter)
            {
                Console.WriteLine("Iteracja {0}", nCounter + 1);
                UnsaveSingleton.Instance.HelloSingleton();
                SaveSingleton.Instance.HelloSingleton();
                SingletonWithoutLocks.Instance.DoSomething();
            }
            Console.ReadKey();
        }
    }
}
