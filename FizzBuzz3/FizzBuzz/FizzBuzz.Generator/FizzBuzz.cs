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
        
        public string OutputWithReport()
        {
            var keywords = new List<string> {"fizz", "buzz", "fizzbuzz", "lucky"};
            
            keywords.ForEach(keyword => _output.Add($"{keyword}: {_output.Count(fb => fb == keyword)}"));
            
            _output.Add($"integer: {_output.Count(fb => int.TryParse(fb, out var output))}");
            
            return Output;
        }
    }
}