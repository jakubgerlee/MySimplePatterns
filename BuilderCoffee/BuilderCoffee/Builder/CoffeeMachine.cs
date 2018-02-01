namespace BuilderCoffee.Builder
{
    public abstract class CoffeeBuilder
    {
        protected Coffee _coffee = new Coffee();

        public Coffee GetBackCoffee()
        {
            return _coffee;
        }

        public virtual void BoilWater()
        {
            _coffee.BoilWater = "boil water";
        }

        public virtual void PourCoffee()
        {
            _coffee.PourCoffee = "Pouring coffee";
        }

        public virtual void PourWater()
        {
            _coffee.PourWater =  "Pouring water";
        }

        public virtual void Milk()
        {
            _coffee.Milk = "no milk";
        }

        public virtual void StirCoffee()
        {
            _coffee.StirCoffee = "stiring coffee";
        }

        public abstract void CoffeeName();
    }
}
