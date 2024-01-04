
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

string myStrijng = "myohmy"; //Dubl quotes
char character = 'a'; // Single quotes
String lowerString = "you get cool built in methods when you do String"; // do this for the methods
string upperString = lowerString.ToUpper();
Console.WriteLine(lowerString);
Console.WriteLine(upperString);
