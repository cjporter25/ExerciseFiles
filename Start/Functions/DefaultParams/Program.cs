using System;

// TODO: Functions can provide default values for their parameters
    // NOTE: By adding an "=" following a parameter name, you can
    //      specify a default value to use if the function call didn't
    //      include an input parameter at that index
    void PrintWithPrefix(string thestr, string prefix="")
    {
        Console.WriteLine($"{prefix} {thestr}");
    }

// TODO: Test the default parameters
    PrintWithPrefix("Hello There!");
    PrintWithPrefix("Hello There!", ">: ");

// TODO: Call with named params
    // NOTE: By specifying a parameter's name before the item, separated by
    //       a semi colon, the parameters can be out of their original order
    PrintWithPrefix(prefix: "% ", thestr: "Hello There!");
