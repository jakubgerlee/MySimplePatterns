using BuilderCoffee;
using FluentBuilder.Builder;

namespace FluentBuilder.ConcreteBuilders
{
    public class CappuccinoCoffee : CoffeeBuilder
    {
        private Coffee _coffee = new Coffee();

        public override CoffeeBuilder StirCoffee()
        {
            throw new System.NotImplementedException();
        }

        public override ` CoffeeName()
        {
            _coffee.CoffeeName = "Cappuccino Coffee";
        }

        public override CoffeeBuilder BoilWater()
        {
            throw new System.NotImplementedException();
        }

        public override CoffeeBuilder PourCoffee()
        {
            throw new System.NotImplementedException();
        }

        public override CoffeeBuilder PourWater()
        {
            throw new System.NotImplementedException();
        }

        public override void Milk()
        {
            base._coffee.Milk = "Pour hot foam milk";
        }
    }
}
