using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace hello_worldtest
{
    [TestClass]
    public class helloWorldTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expectedResult = "Hello World";

            //Act
            string result = helloworld.Program.HelloWorldtoConsole();

            //Assert
            Assert.Equals(expectedResult, result);
        }
    }
}
