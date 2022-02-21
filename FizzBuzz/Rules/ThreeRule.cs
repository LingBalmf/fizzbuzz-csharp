namespace FizzBuzz.Rules
{
    public class ThreeRule : IRule
    {

        public List<string> Apply(List<string> previous, int number)
        {
            if (number % 3 != 0)
            {
                return previous;
            }

            var output = new List<string>(previous);
            output.Add("Fizz");
            return output;
        }
    }
}