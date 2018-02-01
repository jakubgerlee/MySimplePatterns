using BuilderCoffee.Builder;

namespace BuilderCoffee.ConcreteBuilders
{
    public class BlackCoffee : CoffeeBuilder
    {
        public override void  CoffeeName()
        {
            _coffee.CoffeeName = "Black coffee";
        }
    }
}
