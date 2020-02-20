using System;
using System.Collections.Generic;
using System.Text;

namespace BrushUpStudent
{
    public class Person
    {
        private string _name;
        private string _adress;
        private Gender _gender;

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length <= 2) throw new ArgumentOutOfRangeException();
                _name = value;
            }
        }

        public string Adress
        {
            get => _adress;
            set { _adress = value ?? throw new ArgumentNullException("Adress", "Adress should not be null"); }
        }
        public Gender Gender
        {
            get => _gender;
            set => _gender = value;
        }
    }
}
