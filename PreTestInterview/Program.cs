// See https://aka.ms/new-console-template for more information
using PreTestInterview;

OddEvenList<int> oddEvenList = new OddEvenList<int>();

// Adding elements
oddEvenList.Add(10);
oddEvenList.Add(20);
oddEvenList.Add(30);
oddEvenList.Add(40);
oddEvenList.Add(50);

// Removing element at index 2
bool removed = oddEvenList.Remove(2);
Console.WriteLine("Was removal successful? " + removed);

// Getting odd elements
int[] oddElements = oddEvenList.GetOdd();
Console.Write("Odd elements: ");
foreach (int element in oddElements)
{
    Console.Write(element + " ");
}
Console.WriteLine();

// Getting even elements
int[] evenElements = oddEvenList.GetEven();
Console.Write("Even elements: ");
foreach (int element in evenElements)
{
    Console.Write(element + " ");
}
Console.WriteLine();

// Getting random elements
int[] randomElements = oddEvenList.GetRandom();
Console.Write("Random elements: ");
foreach (int element in randomElements)
{
    Console.Write(element + " ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Square Digits");
Console.WriteLine(Square.SquareDigits(9119)); // Output: 811181
Console.WriteLine(Square.SquareDigits(0));    // Output: 0

Console.WriteLine();
Console.WriteLine("String Reverse");
Console.WriteLine(Square.ReverseString("This is an example!")); // Output: "sihT si na !elpmaxe"
Console.WriteLine(Square.ReverseString("double spaces")); // Output: "elbuod secaps"


Console.WriteLine();
Console.WriteLine("Check Characters");

Console.WriteLine(Square.IsValid("()"));      // Output: true
Console.WriteLine(Square.IsValid("([]]"));    // Output: false
Console.WriteLine(Square.IsValid("([{}])"));  // Output: true
Console.WriteLine(Square.IsValid("([[{}]]]")); // Output: false
Console.WriteLine(Square.IsValid(")"));       // Output: false
Console.WriteLine(Square.IsValid("(]}])"));   // Output: false
Console.WriteLine(Square.IsValid("([)]"));    // Output: false
Console.WriteLine(Square.IsValid("{"));

Console.WriteLine();
Console.WriteLine("Highest Socre in word");
Console.WriteLine(Square.HighestScoringWord("i am legend"));    // Output: "legend"
Console.WriteLine(Square.HighestScoringWord("hello world"));   // Output: "world"
Console.WriteLine(Square.HighestScoringWord("this is a word")); // Output: "word"

Console.ReadLine();
