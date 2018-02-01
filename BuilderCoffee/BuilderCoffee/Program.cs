namespace BuilderCoffee
{
    public class Program
    {
        static void Main(string[] args)
        {
            new ProgramLoop().Run();
        }

        /*
         * Wzorzec ten został opisany przez Bandę Czworga (Gang of Four). 
         * Wzorzec projektowy Budowniczy należy do wzorców kreacyjnych. 
         * Idea jaka stoi za tym wzorem jest prosta.
         * Tworzeniem tych samych obiektów (Product), ale 
         * o innych właściwościach zajmują się wyspecjalizowane w tym temacie klasy zwane ConcreteBuilder. 
         * ConcreteBuilder implementują interfejs/klase abstrakcyjna Builder.
         * Klasy ConcreteBuilder są zaprzęgane do działania dzięki klasie Dyrektor.
         * 
         * Director - dyrektor
         * ConcreteBuilders - czarna kawa
         * ConcreteBuilders - cappuccino
         * ConcreteBuilders - latte
         * Builder - interface/abstrakcjyna klasa
         * Product - kawa
         ***/
    }
}
