using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms_and_Data_Structures;
using System.IO;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsSquare()
        {
            // arrange
            int input = 8;
            int expectedOutput = 8 * 8;

            // act
            int result = Algorithms.Square(input);

            // assert
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
