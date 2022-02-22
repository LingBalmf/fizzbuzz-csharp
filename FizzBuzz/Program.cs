using System;
using FizzBuzz.Rules;

namespace FizzBuzz
{
    class Program
    {

        static void Main(string[] args)
        {
            var rules = new List<IApplyable>()
            {
                new ThreeRule(),
                new DivisibleRule(5, "Buzz"),
                new DivisibleRule(7, "Bang"),
                new OverwriteRule(11, "Bong"),
                new ReverseRule(17),
            };

            var fizzBuzzer = new FizzBuzzer(rules);

            for (int i = 1; i <= 256; i++)
            {
                Console.WriteLine(fizzBuzzer.FizzBuzz(i));
            }

        }
    }

}
