using System;

namespace Singleton
{
    public sealed class SaveSingleton
    {
        private static SaveSingleton _instance = null; //zamiast lock, mozna od razu stworzyć obiekt + pusty konstruktor
        private static readonly object locker = new object();
        private int _instanceCounter = 0;

        public SaveSingleton()
        {
            _instanceCounter = 1;
        }

        public static SaveSingleton Instance
        {
            get
            {
                lock (locker)
                {
                    if (_instance == null)
                    {
                        _instance = new SaveSingleton();
                    }
                    return _instance;
                }
            }
        }

        public void HelloSingleton()
        {
            Console.WriteLine("Hello Singleton po raz {0} ", _instanceCounter++);
        }
    }
}


//Słówka kluczowego sealed użytego do deklaracji, które zablokuje dziedziczenie tej klasy
//Prywatnego statycznego pola, które zawiera instancję własnej klasy z domyślną wartością null
//Publicznej statycznej właściwości, która zwraca obiekt swojej klasy(wykorzystuje do
//    tego pole opisane wyżej) i tworzy ten obiekt w sytuacji kiedy właściwość pobierana jest pierwszy raz
//Dowolnej ilości metod użytkowych
//Prywatnego konstruktora, który zablokuje możliwość tworzenia obiektów tej klasy normalną drogą i zapewni,
//    że dostęp odbywać się będzie jedynie za pomocą naszej statycznej właściwości