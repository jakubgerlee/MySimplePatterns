using BuilderCoffee.Builder;

namespace BuilderCoffee.ConcreteBuilders
{
    public class LatteCoffee : CoffeeBuilder
    {
        public override void CoffeeName()
        {
            _coffee.CoffeeName = "Latte Coffee";
        }

        public override void Milk()
        {
            _coffee.Milk = "Pour hot milk";
        }
    }
}
