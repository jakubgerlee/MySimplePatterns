using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderCoffee;

namespace FluentBuilder.Builder
{
    public abstract class CoffeeBuilder
    {
        private Coffee _coffee;

        private Coffee Coffee
        {
            get { return _coffee; }
        }

        public abstract CoffeeBuilder BoilWater();
        public abstract CoffeeBuilder PourCoffee();
        public abstract CoffeeBuilder PourWater();
        public abstract CoffeeBuilder Milk();
        public abstract CoffeeBuilder StirCoffee();
        public abstract CoffeeBuilder CoffeeName();

        public static implicit operator Coffee(CoffeeBuilder cb)
        {
            return cb.CoffeeName()
                .BoilWater()
                .PourWater()
                .Milk()
                .PourCoffee()
                .StirCoffee();

        }
    }
}
