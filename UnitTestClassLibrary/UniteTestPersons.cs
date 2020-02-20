using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrushUpStudent;

namespace UnitTestClassLibrary
{
    [TestClass]
    public class UniteTestPersons
    {
        private Teacher _teacher;
        private Student _student;

        /// <summary>
        /// Initialization of the test with creation of objects.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            _student = new Student();
            _teacher = new Teacher();
        }

        #region ExceptionsTest

        /// <summary>
        /// Test the Students name is less than 2, and throw an exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentName()
        {
            Init();
            //act
            _student.Name = "b";
        }

        /// <summary>
        /// Test the Students adress is null, and throw an exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentAdress()
        {
            //act
            _student.Adress = null;
        }

        /// <summary>
        /// Test the Students semester is more than 8, and throw an exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentSemesterUpper()
        {
            _student.Semester = 9;
        }

        /// <summary>
        /// Test the Students semester is less than 1, and throw an exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentSemesterLower()
        {
            //Act
            _student.Semester = 0;
        }

        /// <summary>
        /// Test the Teachers name is less than 2, and throw an exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTeacherName()
        {
            //act
            _teacher.Name = "b";
        }

        /// <summary>
        /// Test the Teachers Adress is null, and throw an exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestTeacherAdress()
        {
            //act
            _teacher.Adress = null;
        }

        /// <summary>
        /// Test the Teachers salary is 0, and throw an exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTeacherSalary()
        {
            //act
            _teacher.Salary = 0;
        }

        #endregion

        #region CorrectTest

        /// <summary>
        /// Test the Students name is correct
        /// </summary>
        [TestMethod]
        public void TestCorrectStudentName()
        {
            //act
            _student.Name = "Bob";

            //Assert
            Assert.AreEqual("Bob", _student.Name);
        }

        /// <summary>
        /// Test the Students adress is correct
        /// </summary>
        [TestMethod]
        public void TestCorrectStudentAdress()
        {
            //act
            _student.Adress = "Vej";

            //Assert
            Assert.AreEqual("Vej", _student.Adress);
        }

        /// <summary>
        /// Test the Students Semester is correct
        /// </summary>
        [TestMethod]
        public void TestCorrectStudentSemester()
        {
            //Act
            _student.Semester = 4;

            //Assert
            Assert.AreEqual(4, _student.Semester);
        }

        /// <summary>
        /// Test the Students semester is within range
        /// </summary>
        [TestMethod]
        public void TestStudentSemesterIsWithinRange()
        {
            //Act
            _student.Semester = 5;
        }

        /// <summary>
        /// Test the Teachers name is correct
        /// </summary>
        [TestMethod]
        public void TestCorrectTeacherName()
        {
            //act
            _teacher.Name = "Bob";

            //Assert
            Assert.AreEqual("Bob", _teacher.Name);
        }

        /// <summary>
        /// Test the Teachers adress is correct
        /// </summary>
        [TestMethod]
        public void TestCorrectTeacherAdress()
        {
            //act
            _teacher.Adress = "Vej";

            //Assert
            Assert.AreEqual("Vej", _teacher.Adress);
        }

        /// <summary>
        /// Test the teachers salary is correct
        /// </summary>
        [TestMethod]
        public void TestCorrectTeacherSalary()
        {
            //act
            _teacher.Salary = 10;

            //Assert
            Assert.AreEqual(10, _teacher.Salary);
        }

        /// <summary>
        /// Test the Teachers salary is positive
        /// </summary>
        [TestMethod]
        public void TestTeachersSalaryIsPositive()
        {
            //Act
            _teacher.Salary = 100;
        }

        #endregion
    }
}
