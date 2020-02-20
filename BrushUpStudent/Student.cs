using System;

namespace BrushUpStudent
{
    public class Student : Person
    {
        private int _semester;
        /// <summary>
        /// Constructor which makes a student object.
        /// </summary>
        public Student()
        {
        }

        
        

        /// <summary>
        /// Gets the semester of a student, which should be between 1-8.
        /// </summary>
        public int Semester
        {
            get => _semester;
            set
            {
                if (1 >= value || value >= 8)
                    throw new ArgumentOutOfRangeException("Semester", "Semester should be between 1-8.");
                _semester = value;
            }
        }
    }
}
