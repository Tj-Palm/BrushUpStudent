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

        [TestInitialize]

        public void Init()
        {
            _student = new Student();
            _teacher = new Teacher();
        }

        #region ExceptionsTest

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentName()
        {
            Init();
            //act
            _student.Name = "b";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudentAdress()
        {
            //act
            _student.Adress = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentSemester()
        {
            _student.Semester = 9;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTeacherName()
        {
            //act
            _teacher.Name = "b";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestTeacherAdress()
        {
            //act
            _teacher.Adress = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTeacherSalary()
        {
            //act
            _teacher.Salary = 0;
        }

        #endregion

        #region CorrectTest

        [TestMethod]
        public void TestCorrectStudentName()
        {
            //act
            _student.Name = "Bob";
        }

        [TestMethod]
        public void TestCorrectStudentAdress()
        {
            //act
            _student.Adress = "Vej";
        }

        [TestMethod]
        public void TestCorrectStudentSemester()
        {
            _student.Semester = 4;
        }

        [TestMethod]
        public void TestCorrectTeacherName()
        {
            //act
            _teacher.Name = "Bob";
        }

        [TestMethod]
        public void TestCorrectTeacherAdress()
        {
            //act
            _teacher.Adress = "Vej";
        }

        [TestMethod]
        public void TestCorrectTeacherSalary()
        {
            //act
            _teacher.Salary = 10;
        }

        #endregion

    }
}
