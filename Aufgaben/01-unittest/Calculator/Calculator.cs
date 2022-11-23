using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
<<<<<<< HEAD
            return summandA + summandB;//+1
        }
=======
            return summandA + summandB;
        }

>>>>>>> a90bf9cbb1aa4c03254e7b2265efffaf68e0a82f
        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }
<<<<<<< HEAD
        public int Multiply(int multiplientA, int multiplientB)
        {
            return multiplientA * multiplientB;
        }
        public int Devide(int DividentA, int DividentB)
        {

            if (DividentA == 0 || DividentB == 0)
            {
                throw new ArgumentException();
            }
            return DividentA / DividentB;
        }
    }
}
=======
    }
}
>>>>>>> a90bf9cbb1aa4c03254e7b2265efffaf68e0a82f
