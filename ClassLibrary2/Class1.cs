using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        public bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first");
        }

        public bool IsEven(int candidate)
        {
            return candidate % 2 == 0;
        }

        public bool IsOdd(int candidate)
        {
            return candidate % 2 == 1;
        }

        public int AddANumberToSeven(int number)
        {
            return number + 7;
        }

        public string GenerateString(int length)
        {
            return new string('x', length);
        }

    }
}
