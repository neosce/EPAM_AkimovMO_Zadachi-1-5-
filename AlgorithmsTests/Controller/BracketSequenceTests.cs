using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Controller.Tests
{
    [TestClass()]
    public class BracketSequenceTests
    {
        [TestMethod()]
        public void BracketSeqTest()
        {
            // Arrange
            string bracket = "()";

            // Act
            var bracketSequence = new BracketSequence();

            // Assert
            Assert.IsTrue(bracketSequence.BracketSeq(bracket));
        }
    }
}