using System;

namespace Modifiers
{
    // IMPORTANT: "Access Modifiers"
    // Public:    Method or class member can be accessed by any other 
    //            code within your program
    // Protected: Method or class member can be accessed only by code
    //            within the class or a subclass
    // Private:   Method or class member can only be accessed by code 
    //            within the class definition itself 
    // 
    /*
        EXAMPLE Part 1:

        class A {                       class Program {
            public void fnA1();             static void Main() {
            protected void fnA2();              A clsa = new A();
            private void fnA3();                
        }                                       clsa.fnA1();
                                                clsa.fnA2();
                                                clsa.fnA3(); 
        Calling fnA1 is good - declared as public
        Calling fnA2 is bad - declared as protected
            *Not accessible outside of the "A" class
        Calling fnA3 is bad - declared as private
            *Only code inside class "A"s definition fits that description

        EXAMPLE Part 2: (Class B Derives from Class A)
        class B : A {  
            fnB1() {                     
                fnA1();     // Works because its public       
                fnA2();     // Works because class B is a subclass of A
                            //      which means it has access to all A methods         
                fnA3();     // 
            }                
        }   
        Calling fnA1 is good - declared as public and thus would always work
        Calling fnA2 is good - B is derived from A which means it has access to
                               all of A's methods.
        Calling fnA3 is bad  - was declared as private and can only be used
                               within the context of the original definition
    
    
    */ 
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Book instance
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

            // In previous example, this would fail, but will now
            // work since the field name is declared as public (in Book.cs)
            b1._name = "Cat in the Hat";
            Console.WriteLine(b1.GetDescription());

        // TODO: set data using functions instead of accessing fields directly
            b1.SetName("Grapes of Wrath");
            b1.SetAuthor("John Steinbeck");
            b1.SetPagecount(464);
            Console.WriteLine(b1.GetDescription());
        // IMPORTANT: This is simply the standard way. C# has "properties"
        //            that make this process easier.
        }
    }
}
