using System;

namespace Inheritance
{
    // TODO: Declare "Book" as a subclass of Publication
    class Book : Publication {
        private string _author;
        // private int _pagecount;
        // private decimal _price;

        // Used the base() keyword to initialize the base class alongside the
        //  subclass. This removes the need for redundant variables in the 
        //  subclass
        public Book(string name, string author, int pagecount, decimal price) 
            : base(name, pagecount, price) {
            _author = author;
        }

        public string Author {
            get => _author;
            set => _author = value;
        }

        // TODO: Use the override keyword to override a base class method
        //  Note: The overridden class must have the keyword "virtual"
        public override string GetDescription() {
            return $"{Name} by {Author}, {Pagecount} pages";
        }

    }
}