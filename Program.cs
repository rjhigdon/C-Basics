// Notes for Video Course

////////////////////////////////////Type Casting

/*
double myDubl = 9803837;
int myInt;

//myInt = myDubl; Implicit conversion
myInt = (int)myDubl; //explicit conversion

Console.WriteLine(myInt);

///Casting strings to Ints

string myString = "123456";
int strToInt;

if (int.TryParse(myString, out strToInt))
{
    Console.WriteLine($"{strToInt} cast as int");
}
else
{
    Console.WriteLine("cast failure");
}
Console.WriteLine(strToInt);
Console.WriteLine(strToInt.GetType());
*/

//////////////////////////////////// Arrays
// Fixed vs Dynamic
/*
int[] myArr = new int[2]; //the two represents the length. This is a FixedArr
myArr[0] = 1;
myArr[1] = 2;
int[] myArr2 = new int[2] { 1, 2 }; // Can also declare like this
Console.WriteLine(myArr); //this only prints datatype
Console.WriteLine(String.Join(", ", myArr)); // This prints contents

int[] anotherArr = new int[] { 1, 2, 3, 4 }; //Length not specified. Dynamic

Console.WriteLine(String.Join(", ", anotherArr));
*/

//////////////////////////////////// Strings
/*
string myStrijng = "myohmy"; //Dubl quotes
char character = 'a'; // Single quotes
String lowerString = "you get cool built in methods when you do String"; // do this for the methods
string upperString = lowerString.ToUpper();
Console.WriteLine(lowerString);
Console.WriteLine(upperString);

// Literal vs Verbatim
string literalFilename = "c:\\ProgramFiles"; // normal
string verbatimString = @"c:\ProgramFiles"; // handles escape sequences for you

// Immutablity

string str1 = "Hello";
string str2 = "World";

Console.WriteLine($"{str1}, {str2}");
Console.WriteLine("{0}, {1}", str1, str2);
*/

//////////////////////////////////// Lists

// beefy arrays
/*
using Learning;

List<Part> lst = new List<Part>();

lst.Add(new Part { PartName = "firstName", PartId = 1 });
lst.Add(new Part { PartName = "secondName", PartId = 2 });

foreach(Part part in lst)
{
    Console.WriteLine(part.PartName.ToString() + ", " + part.PartId.ToString());
}
*/

//////////////////////////////////// If/Else
/*
int funNum = 0;
string answer = "";
if (funNum < 1)
{
    answer = "funNum < 1";
    Console.WriteLine(answer);
}
else
{
    answer = "funNum > 1";
    Console.WriteLine(answer);
}

// integrating boolean

bool isEqual = 5 == 5; //true
bool notEqual = 5 != 1; //true

bool alsoNotEqual = 5 == 1; //false

bool andAnd = 5 == 5 && 3!=7; //true
bool orOr = 5 == 4 || 3!=7; //true
Console.WriteLine(orOr);

//Inline Cnditional 
int inlineCondition = 3 > 2 ? 10 : 5;
// Literal Translation: if 3>2, inLineCondition = 10, else = 5
// to redo lines 88-99 do:
answer = 0 < 1 ? "funNum < 1" : "funNum is > 1";
Console.WriteLine(answer);
*/

//////////////////////////////////// Switch statements & enums

/*
using static Learning.EnumEx;

DisplayMeasurement(-1);
DisplayMeasurement(100);
DisplayMeasurement(10);

void DisplayMeasurement(double measurement)
{
    switch (measurement)
    {
        case < 0.0:

            break;
        case > 15.0:
            Console.WriteLine($"Measeured value is {measurement}; too low");
            break;
        case double.NaN:
            Console.WriteLine("Not a number");
            break;
        default: Console.WriteLine($"Measurement value is {measurement}.");
            break;
    }
}
//Switch Statements

State state = State.Active;

switch (state)
{
    case State.Active:
        Console.WriteLine("active");
            break;
    case State.Inactive:
        Console.WriteLine("Inactive");
            break;
    default:
        throw new Exception($"Unknown state: {state}");
}
*/
//////////////////////////////////// For Loops
/*

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"I have iterated {i + 1} times");

}

//////////////////////////////////// ForEach

var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };

foreach (int num in fibNumbers)
{
    Console.WriteLine($"value of num is {num}");
}

string fibNumbers2 = "0, 1, 1, 2, 3, 5";
foreach (char num in fibNumbers2)
{
    Console.WriteLine($"Value of num in this string is {num}");
}
*/

//////////////////////////////////// Classes
// Classes are nouns and they can have traits and Methods
// they store the traits of a certain object and the things it does 
// they provide the structure for an object when we make one
// For example, If we were to make a dog, what would it be/do?
// It would have a breed, age, bark, etc.

// To build a dog check Dog.cs
// with a built dog class we can utilize its features like this:

/*
using Learning;

Dog dog = new Dog();
dog.Bark();
Console.WriteLine(dog.Name);
Console.WriteLine(dog.Age);
*/

//////////////////////////////////// Interfaces/ Abstract Classes

// interfaces are rules of the road for prebuilt functionalites. A contract
// after you make your I{classname} file you can have your class inherit the Interfaces with:
//                                                                        public class Class : IClass
// it will auto populate the Interfaces (Check Dog and IDogWalker for more elaboration)

/*
using Learning;

///
Dog arlo = new Dog();
arlo.Bark();

IDogWalker arlo2 = new Dog();
arlo2.WalkToCountry();
arlo2.WalkToCountry();
*/

// You use abstract classes in the same way but you use these more for the adjectives than the verbs
// you inherit the same way (using the Ping class) 
// you can never instantiate it on its own, it can only pass on traits
//                                  Like so: BasePing basePing = new BasePing();

// you can also edit the init for the any of the inheriting classes by
// putting virtual in the base class and override in the inheriting class (Check IPV6 and basePing class)


using Learning;

PingIPV6 pingIPV6 = new PingIPV6();
Console.WriteLine(pingIPV6.Init());
Console.WriteLine(pingIPV6.SendPing());

PingIPV4 pingIPV4 = new PingIPV4(); 
Console.WriteLine(pingIPV4.Init());
Console.WriteLine(pingIPV4.SendPing());



