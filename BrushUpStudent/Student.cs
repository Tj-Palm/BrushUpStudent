using System;

namespace BrushUpStudent
{
    class Student : Person
    {
        private int _semester;

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
