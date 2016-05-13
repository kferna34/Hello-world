using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange
            string expectedResult = "Hello World";

            //Act
            string result = hello_world.Program.HelloWorldToConsole();

            //Assert
            Assert.Equals(expectedResult, result);
        }
    }
}
