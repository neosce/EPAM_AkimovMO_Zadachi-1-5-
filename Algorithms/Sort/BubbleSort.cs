using Algorithms.Controller;

namespace Algorithms.Sort
{
    public class BubbleSort
    {
        readonly Swap swap = new Swap();

        public int[] Bubble(int[] items)
        {

            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[i] > items[j])
                    {
                        swap.Swapped(items, i, j);
                    }
                }
            }
            return items;
        }

    }
}
