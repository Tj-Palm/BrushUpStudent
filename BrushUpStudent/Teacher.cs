using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUpStudent
{
    public class Teacher : Person
    {
        private int _salary;
        /// <summary>
        /// Constructor which makes a teacher object.
        /// </summary>
        public Teacher()
        {
        }

        
        

        /// <summary>
        /// Get the salary of a teacher, which cannot be 0.
        /// </summary>
        public int Salary
        {
            get => _salary;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Salary", "Salary should be more positive than 0.");
                _salary = value;
            }
        }
    }
}
