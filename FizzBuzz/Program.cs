using System;
using FizzBuzz.Rules;

namespace FizzBuzz
{
    class Program
    {

        static void Main(string[] args)
        {
            var rules = new List<IRule>()
            {
                new ThreeRule(),
                new ReverseRule(17),
            };

            var fizzBuzzer = new FizzBuzzer(rules);

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzzer.FizzBuzz(i));
            }

        }
    }

}
