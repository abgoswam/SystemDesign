using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedListIterator
{

    public class NestedIterator
    {
        private int _currentIndex = 0;
        private List<int> _input;

        public NestedIterator(List<int> input)
        {
            _input = input;
        }

        public bool HasNext()
        {
            if(_currentIndex < _input.Count)
                return true;

            return false;
        }

        public int Next()
        {
            return _input[_currentIndex++];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int>() { 1, 2, 3, 4, 5 };

            var ni = new NestedIterator(input);
            while(ni.HasNext())
            {
                Console.WriteLine(ni.Next());
            }
        }
    }
}
