using System;

namespace Algorithms.Sort
{
    public class InsertionSort
    {

        public void Insertion(ref int[] items)
        {
            int sortedRangeEndIndex = 1;
            while(sortedRangeEndIndex < items.Length)
            {
                if(items[sortedRangeEndIndex].CompareTo(items[sortedRangeEndIndex - 1]) < 0)
                {
                    int insertIndex = FindInsertionIndex(items, items[sortedRangeEndIndex]);
                    Insert(items, insertIndex, sortedRangeEndIndex);
                }
                sortedRangeEndIndex++;
            }
        }

        private static int FindInsertionIndex(int[] items, int valueToInsert)
        {
            for(int i=0; i < items.Length; i++)
            {
                if(items[i].CompareTo(valueToInsert) > 0)
                {
                    return i;
                }
            }
            throw new NotImplementedException("Index - not found");
        }

        private static void Insert(int[] items, int insertIndexAt, int sortedRangeEndIndexFrom)
        {
            int temp = items[insertIndexAt];
            items[insertIndexAt] = items[sortedRangeEndIndexFrom];
            for(int cur = sortedRangeEndIndexFrom; cur>insertIndexAt; cur--)
            {
                items[cur] = items[cur - 1];
            }
            items[insertIndexAt + 1] = temp;
        }

        
    }
}