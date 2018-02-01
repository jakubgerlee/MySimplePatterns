using System.Diagnostics;
using BuilderCoffee;
using FluentBuilder.Builder;

namespace FluentBuilder.ConcreteBuilders
{
    public class BlackCoffee : CoffeeBuilder
    {
        private CoffeeBuilder coffee;


        public override CoffeeBuilder BoilWater()
        {
            coffee.BoilWater = "d";
        }

        public override CoffeeBuilder PourCoffee()
        {
            throw new System.NotImplementedException();
        }

        public override CoffeeBuilder PourWater()
        {
            throw new System.NotImplementedException();
        }

        public override CoffeeBuilder Milk()
        {
            throw new System.NotImplementedException();
        }

        public override CoffeeBuilder StirCoffee()
        {
            throw new System.NotImplementedException();
        }

        public override void  CoffeeName()
        {
            coffee. = "Black coffee";
        }
    }
}
