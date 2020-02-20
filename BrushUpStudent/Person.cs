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

        /// <summary>
        /// Gets name of person, which should be more than 2 characters
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length <= 2) throw new ArgumentOutOfRangeException("Name", "Name should be more than 2 character");
                _name = value;
            }
        }

        /// <summary>
        /// Gets Adress of person, which can't be null.
        /// </summary>
        public string Adress
        {
            get => _adress;
            set { _adress = value ?? throw new ArgumentNullException("Adress", "Adress should not be null"); }
        }

        /// <summary>
        /// Gets the Gender of a person from the enum Gender class.
        /// </summary>
        public Gender Gender
        {
            get => _gender;
            set => _gender = value;
        }
    }
}
