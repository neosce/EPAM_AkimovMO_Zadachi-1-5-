using System;

namespace Algorithms.Search
{
    public class SearchElement
    {

        public bool SearchEl(int[] items, int value)
        {
            bool error = false;
            for(int i = 0; i < items.Length; i++)
            {
                if (items[i] == value)
                {
                    error = true;
                    return error;
                }
            }
            return error;
        }

        public void SearchEl(string[] items)
        {
            bool error = false;
            for (int i = 0; i < items.Length; i++)
            {
                int check = 0;
                for (int j = 0; j < items.Length; j++)
                {
                    if (items[i] == items[j])
                    {
                        check++;
                    }
                }

                if (check == 1)
                {
                    Console.WriteLine(items[i]);
                    error = true;
                }
            }
            if (!error)
                Console.WriteLine("Strings - no found!");

        }

    }
}
