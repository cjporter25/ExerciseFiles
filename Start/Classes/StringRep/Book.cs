using System;

namespace StringRep {
    class Book {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; }

        public Book(string name, string author, int pages) {
            Name = name;
            Author = author;
            PageCount = pages;
        }

    // TODO: The ToString method generates a string represenation of the object
        // Note: "ToString" is virtual, meaning it can be overriden
        // Purpose: This allows the programmer to custom make what the "ToString" 
        //          method will do for a unique class.
        public override string ToString() {
            return $"Book: {Name} by {Author}";
        }

    // TODO: ToString can be overloaded to give different format versions
    // Notice that this version is NOT an override function
        public string ToString(char format) {
            // If chosen format is "B" output a condensed version
            if (format == 'B') {
                return $"Book: {Name}:{Author}";
            }
            // If chosen format is "F" output a full version
            if (format == 'F') {
                return $"Book: {Name} by {Author} is {PageCount} pages";
            }
            // If neither format is chosen, output the original ToString function.
            //  Because it is overriden, it'll refer to the one I made
            return ToString();
        }
    }
}