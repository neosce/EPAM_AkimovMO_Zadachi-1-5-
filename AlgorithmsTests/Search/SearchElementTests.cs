using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Search.Tests
{
    [TestClass()]
    public class SearchElementTests
    {
        [TestMethod()]
        public void SearchElTest()
        {
            // Arrange
            int[] arraySort = { 1, 2, 3, 4, 5 };

            // Act
            var searchEl = new SearchElement();

            // Assert
            Assert.IsTrue(searchEl.SearchEl(arraySort, 3));
        }
    }
}