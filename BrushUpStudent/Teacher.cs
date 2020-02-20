using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUpStudent
{
    class Teacher : Person
    {
        private int _salary;

        public int Salary
        {
            get => _salary;
            set
            {
                if (value >= 0)
                    throw new ArgumentOutOfRangeException("Salary", "Salary should be more positive than 0.");
                _salary = value;
            }
        }
    }
}
