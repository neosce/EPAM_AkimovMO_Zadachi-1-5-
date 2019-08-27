using System;

namespace Algorithms.Controller
{
    public class Factorial
    {

        public int Fact(int value)
        {
            int fact = 1;
            for (; value > 0; fact *= value--) ;
            return fact;
        }

    }
}
