using System;

namespace MyFirstApp.Models
{
    public class SavedItemModel
    {
        private double _rating;
        public string Name { get; set; }
        public string Address { get; set; }

        public double Rating
        {
            get => _rating;
            set
            {
                if (value < 0 ||
                    value > 5)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                _rating = value;
            }
        }

        public int FeedBacksCount { get; set; }
        public string ImageSource { get; set; }
    }
}