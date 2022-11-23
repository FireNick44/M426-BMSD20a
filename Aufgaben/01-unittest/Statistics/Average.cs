using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
<<<<<<< HEAD
            if (numbers.Count == 0)
            {
                throw new ArgumentException();
            }
=======
>>>>>>> a90bf9cbb1aa4c03254e7b2265efffaf68e0a82f
            int sum = 0;
            double mean = 0.0;

            foreach (int number in numbers)
            {
                sum += number;
            }
<<<<<<< HEAD
            mean = (double)sum / numbers.Count;
            return mean;
        }
        public double Median(List<int> numbers)
        {
            numbers.Sort();
            //gerade
            if (numbers.Count % 2 == 0)
            {
                return (double)(numbers[(int)numbers.Count / 2] + numbers[((int)numbers.Count / 2) - 1]) / 2;
            }
            //ungerade
            else
            {
                return numbers[(int)Math.Floor((double)numbers.Count / 2)];
            }
        }
    }
}
=======

            mean = (double)sum / numbers.Count;
            return mean;
        }
    }
}
>>>>>>> a90bf9cbb1aa4c03254e7b2265efffaf68e0a82f
