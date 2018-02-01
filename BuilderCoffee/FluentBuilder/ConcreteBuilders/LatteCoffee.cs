using FluentBuilder.Builder;

namespace FluentBuilder.ConcreteBuilders
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
