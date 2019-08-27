using System;

namespace Algorithms.Controller
{
    public class ShowArray
    {

        public void Show<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array[i]);
            Console.WriteLine();
        }

    }
}
