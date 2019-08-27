namespace Algorithms.Controller
{
    public class Swap
    {

        public void Swapped(int[] items, int left, int right)
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

    }
}
