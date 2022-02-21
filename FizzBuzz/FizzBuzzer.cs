namespace FizzBuzz
{
	public class FizzBuzzer 
	{
        public string FizzBuzz(int i)
        {

            string str = "";

            if (i % 3 == 0)
            {
                str += "Fizz";
            }
            if (i % 5 == 0)
            {
                str += "Buzz";
            }
            if (str.Length == 0)
            {
                str = i.ToString();
            }
            return str;
        }
    }
}
