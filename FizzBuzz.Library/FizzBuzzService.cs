namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public string Print(int number)
        {
            if (IsDisibleByThree(number) && IsDisibleByFive(number))
            {
                return "FizzBuzz";
            }
            else if (IsDisibleByFive(number))
            {
                return "Buzz";
            }
            else if (IsDisibleByThree(number))
            {
                return "Fizz";
            }
            else
            {
                return number.ToString();
            }

        }

        private bool IsDisibleByThree(int n)
        {
            return n % 3 == 0;
        }

        private bool IsDisibleByFive(int n)
        {
            return n % 5 == 0;
        }
    }
}