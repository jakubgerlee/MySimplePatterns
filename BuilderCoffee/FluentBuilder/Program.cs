using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderCoffee;
using FluentBuilder.Builder;
using FluentBuilder.ConcreteBuilders;

namespace FluentBuilder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var coffeeMachine = new CoffeeMachine();

            var blackCoffee = coffeeMachine.DoCoffee(new BlackCoffee());

            Console.ReadKey();
        }
    }
}
