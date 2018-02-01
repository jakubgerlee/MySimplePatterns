using BuilderCoffee.Builder;

namespace BuilderCoffee.Builders
{
    public class CappuccinoCoffee : CoffeeBuilder
    {
        public override void CoffeeName()
        {
            _coffee.CoffeeName = "Cappuccino Coffee";
        }

        public override void Milk()
        {
            _coffee.Milk = "Pour hot foam milk";
        }
    }
}
