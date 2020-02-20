using System;

namespace Book
{
    public class Book
    {
        private double _price;

        public string Title { get; set; }
        public string Author { get; set; }

        /// <summary>
        /// Get price of book, which should be more than 0.0 - else an exception
        /// </summary>
        public double Price
        {
            get => _price;
            set
            {
                if (value < 0.0) throw new ArgumentOutOfRangeException();
                _price = value;
            }
        }

        /// <summary>
        /// ToString method which prints out Author, Title and Price of the book.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Author + " " + Title + " " + Price;
        }
    }
}
