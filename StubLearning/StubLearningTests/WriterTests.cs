using Microsoft.VisualStudio.TestTools.UnitTesting;
using StubLearning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubLearning.Tests
{
    [TestClass()]
    public class WriterTests
    {
        [TestMethod()]
        public void WriteInputTest()
        {
            //Arrange
            Writer write = new Writer();
            string two = new InputTwo().input();

            //Act
            var resultString = write.WriteInput(two);

            //Assert
            Assert.AreEqual("Always Two", resultString);
        }
    }
}