using BuilderCoffee.Builder;

namespace BuilderCoffee
{
    public class Director
    {
        private CoffeeBuilder _coffeeBuilder;

        public void SetBuilder(CoffeeBuilder coffeeBuilder)
        {
            _coffeeBuilder = coffeeBuilder;
        }
        public void PrepareCoffee()
        {
            _coffeeBuilder.CoffeeName();
            _coffeeBuilder.BoilWater();
            _coffeeBuilder.PourCoffee();
            _coffeeBuilder.PourWater();
            _coffeeBuilder.Milk();
            _coffeeBuilder.StirCoffee();
        }

        public Coffee GetCoffee()
        {
            return _coffeeBuilder.GetBackCoffee();
        }

    }
}
