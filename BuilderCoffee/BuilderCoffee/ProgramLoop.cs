using System;
using BuilderCoffee.Builders;
using BuilderCoffee.ConcreteBuilders;

namespace BuilderCoffee
{
    public class ProgramLoop
    {
        public void Run()
        {
            //Do coffee
            var director = new Director();
            var coffeeLate = new LatteCoffee();
            var blackCoffee = new BlackCoffee();
            var cappuccino = new CappuccinoCoffee();

            //first coffee
            director.SetBuilder(blackCoffee);
            director.PrepareCoffee();
            var coffee1 = director.GetCoffee();
            coffee1.GetCoffee();

            //2nd coffee
            director.SetBuilder(coffeeLate);
            director.PrepareCoffee();
            var coffee2 = director.GetCoffee();
            coffee2.GetCoffee();

            //3rd coffee
            director.SetBuilder(cappuccino);
            director.PrepareCoffee();
            var coffee3 = director.GetCoffee();
            coffee3.GetCoffee();


            Console.ReadKey();
        }
    }
}
