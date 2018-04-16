using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter
{
/// <summary>
/// Classes of predicates.
/// </summary>
    public class ContainsDigit : IPredicate<int>
    {
        private int digit;

        public int Digit
        {
            get => digit;
            set
            {
                if (value < 0 || value > 9)
                {
                    throw new ArgumentOutOfRangeException(nameof(digit));
                }

                digit = value;
            }
        }

        public ContainsDigit(int digit)
        {
            Digit = digit;
        }

        public bool IsMatch(int number)
        {
            while (number != 0)
            {
                if (number % 10 == Digit || number % 10 == -Digit)
                {
                    return true;
                }
                number = number / 10;
            }
            return false;
        }
    }

    public class EvenNumber : IPredicate<int>
    {
        public bool IsMatch(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }

            return false;
        }
    }

    public class OddNumber : IPredicate<int>
    {
        public bool IsMatch(int number)
        {
            if (number % 2 == 0)
            {
                return false;
            }

            return true;
        }
    }

    public class SimpleNumber : IPredicate<int>
    {
        public bool IsMatch(int number)
        {
            if (number < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }

}
