// Exercise file for LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for .NET Data Types

// Declare some types with values
int a = 1;
char c = 'A';
float f = 123.45f;
decimal d = 400.85m;
int b = default;
bool tf = default;

Console.WriteLine($"{a}, {b}, {tf}, {c}, {f}, {d}");

// TODO: implicit type conversion
Console.WriteLine($"{c + a}"); // 66
Console.WriteLine($"{(char)(c + a)}"); // B

Console.WriteLine($"{f + a}"); // 124.45
Console.WriteLine($"{f + c}"); //188.45


// TODO: Create an instance of a struct (which is a value type)
s s1;
s1.a = 5;
s1.b = false;


// Perform an operation on a struct
void StructOp(s theStruct) {
    // Modify the struct properties inside the function
    theStruct.a = 10;
    theStruct.b = true;
    Console.WriteLine($"{theStruct.a}, {theStruct.b}");
}

//` using a struct will not change the s1 variables
Console.WriteLine("Structs are passed by copy, since they are value types:");
Console.WriteLine($"{s1.a}, {s1.b}"); //5, False
StructOp(s1); //10, True
Console.WriteLine($"{s1.a}, {s1.b}"); //5, False

// TODO: Create an object instance of a class (which is a reference type)

MyClass cl = new MyClass{a = 5, b = false};

// Perform an operation on the class
void ClassOp(MyClass theClass) {
    // Modify some of the properties of the class inside the function
    theClass.a = 10;
    theClass.b = true;
    Console.WriteLine($"{theClass.a}, {theClass.b}");
}

//` using a class will change the c1 class variables
Console.WriteLine("Objects are passed by reference, since they are reference types:");
Console.WriteLine($"{cl.a}, {cl.b}"); // 5, False
ClassOp(cl); // 10, True
Console.WriteLine($"{cl.a}, {cl.b}"); //10, True

// These are declared at the bottom of the file because C# requires
// top-level statements to come before type declarations
class MyClass {
    public int a;
    public bool b;
}

struct s {
    public int a;
    public bool b;
}
