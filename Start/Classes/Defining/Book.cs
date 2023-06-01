using System;

namespace Defining
{
    // classes have a name, unique within the namespace
    // Usage:
    //  1. Use the class keyword, followed by the preferred class name
    //  2. Making a class public means it's accessible by any other code 
    public class Book
    {
        // CLASSES have MEMBER variables, or "fields" to hold data
        string _name;
        string _author;
        int _pagecount;

        // CLASSES have one or more constructors, which are class methods
        //      designed to create sed object
        public Book(string name, string author, int pages) {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        // METHODS are used to operate on the class and data
        public string GetDescription() {
            return $"{_name} by {_author}";
        }

    }
}
