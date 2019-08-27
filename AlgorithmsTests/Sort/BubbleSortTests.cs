using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Sort.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void BubbleTest()
        {

            // Arrange
            int[] array = { 5, 4, 3, 2, 1 };
            int[] arraySort = { 1, 2, 3, 4, 5 };

            // Act
            var bubbleTest = new BubbleSort();

            // Assert
            CollectionAssert.AreEqual(arraySort, bubbleTest.Bubble(array));

        }
    }
}