using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        [DataRow("cv")]
        public void StudentTest(string value)
        {
            //Arrange
            Student stu = new Student();

            //Act
            string expected = "cv";

            //Assert
            Assert.AreEqual(expected, value);
        }


    }
}