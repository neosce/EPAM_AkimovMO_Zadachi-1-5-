using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Controller.Tests
{
    [TestClass()]
    public class FactorialTests
    {
        [TestMethod()]
        public void FactTest()
        {
            // Arrange
            int exp = 120;

            // Act
            var fact = new Factorial();

            // Assert
            Assert.AreEqual(exp, fact.Fact(5));
        }
    }
}