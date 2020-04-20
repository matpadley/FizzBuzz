namespace FizzBuzz.Generator
{
    public class FizzBuzzNumber
    {
        private readonly int _number;

        public FizzBuzzNumber(int number)
        {
            _number = number;
        }

        public override string ToString()
        {
            if (_number.ToString().Contains("3")) return "lucky";
            
            if (IsFifteenMultiplier(_number)) return "fizzbuzz";

            if (IsThreeMultiplier(_number))return "fizz";

            return IsFiveMultiplier(_number) ? "buzz" : _number.ToString();
        }
        
        private bool IsThreeMultiplier(int input) => input % 3 == 0;
        private bool IsFiveMultiplier(int input) => input % 5 == 0;
        private bool IsFifteenMultiplier(int input) => IsThreeMultiplier(input) && IsFiveMultiplier(input);
    }
}