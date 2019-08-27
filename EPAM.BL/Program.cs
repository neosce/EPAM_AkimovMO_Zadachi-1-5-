using System;
using Algorithms.Sort;
using Algorithms.Search;
using Algorithms.Controller;

namespace EPAM.BL
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 10, 2, 45, 4, 5, 1, 2, 4, 2, 67, 5, 4, 3, 5, 3 };
            int[] array2 = { 5, 4, 3, 2, 6, -99, 3, 43, -2, 4, 5, -3, 5, 2, 3, 5, 3 };
            string[] array3 = { "one", "two", "three", "four", "one" };

            //var showArray = new ShowArray();
            var sortSwap = new BubbleSort();
            var sortInsertion = new InsertionSort();
            var searchEl = new SearchElement();
            var factorial = new Factorial();
            var bracketSequence = new BracketSequence();

            Cwl("Exercise: 1");
            Cwl("Array: ");
            //showArray.Show(arraySort); - способ показать массив в "ручную"
            Cwl(string.Join(", ", array));

            Cwl("Array sort Bubble: ");
            Cwl(string.Join(", ", sortSwap.Bubble(array)));

            Cwl("Array sort Insertion: ");
            sortInsertion.Insertion(ref array2);
            Cwl(string.Join(", ", array2));

            Cwl("Exercise: 2");
            Cwl("Search element: ");
            Cwl(searchEl.SearchEl(array2, 4));

            Cwl("Exercise: 3");
            Cwl("Search strings: ");
            searchEl.SearchEl(array3);

            Cwl("Exercise: 4");
            Cwl("5! =");
            Cwl(factorial.Fact(5));

            Cwl("Exercise: 5");
            Cwl("BracketSequence: ");
            Cwl(bracketSequence.BracketSeq("(())[][()]{}"));

            Console.ReadKey();

        }

        private static void Cwl(object text) => Console.WriteLine(text);

    }
}