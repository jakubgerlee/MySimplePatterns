using System;

namespace BuilderCoffee
{
    public class Coffee
    {
        public string CoffeeName { get; set; }
        public string BoilWater { get; set; }
        public string PourCoffee { get; set; }
        public string PourWater { get; set; }
        public string Milk { get; set; }
        public string StirCoffee { get; set; }

        public Coffee(string coffeeName)
        {
            CoffeeName = coffeeName;
        }



        public void GetCoffee()
        {
            var coffee = $" Coffee Name: {CoffeeName},\n" + $" Boil Water: {BoilWater},\n" +
                         $" Pour Coffee: {PourCoffee},\n" + $" Pour Water: {PourWater},\n" + $" Milk: {Milk},\n" +
                         $" Stir Coffee: {StirCoffee}, \n\n";

            Console.WriteLine(coffee);
        }
    }
}
