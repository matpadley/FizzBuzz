using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Generator
{
    public class FizzBuzz
    {
        private readonly ICollection<string> _output;

        public FizzBuzz(IEnumerable<int> range)
        {
            _output = new List<string>();
            
            range.ToList().ForEach(input =>
            {
                var fizzBuzzNumber = new FizzBuzzNumber(input);
                
                _output.Add(fizzBuzzNumber.ToString());
            });
        }
        
        public string Output => string.Join(" ", _output);
    }
}