using System;

Console.WriteLine("***** Loops and Choices *****");

// Uncomment function(s) to run it when the application runs
// ForLoopExample();
// ForEachLoopExample();
// LinqQueryOverInts();
// WhileLoopExample();
// DoWhileLoopExample();
// IfElseExample();
// IfElsePatternMatching();
// IfElsePatternMatchingUpdatedInCSharp9();
// ExecuteIfElseUsingConditionlaOperator();
// ConditionalRefExample();
// LogicalOperatorsExample();
// SwitchExample();
// SwitchOnStringExample();
// SwitchOnEnumExample();
// SwitchWithGoto();
// ExecutePatternMatchingSwitch();
// ExecutePatternMatchingSwitchWithWhen();
// Console.WriteLine(RockPaperScissors("paper", "rock"));
// Console.WriteLine(RockPaperScissors("scissors", "rock"));

Console.ReadLine();


// Basic for loop
static void ForLoopExample()
{
    Console.WriteLine("================ For Loop ================");
    // Note! "i" is only visible within the scope of the for loop
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("Number is: {0} ", i);
    }
    // "i" is no visible here
    Console.WriteLine();
}

static void ForEachLoopExample()
{
    Console.WriteLine("================ For Each Loop ================");
    string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
    foreach (string c in carTypes)
    {
        Console.WriteLine(c);
    }

    int[] myInts = { 10, 20, 30, 40 };
    foreach (int i in myInts)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine();
}

static void LinqQueryOverInts()
{
    Console.WriteLine("================ Foreach With LINQ ================");

    int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

    // LINQ query!
    var subset = from i in numbers where i < 10 select i;
    Console.WriteLine("Values in subset: ");

    foreach (var i in subset)
    {
        Console.WriteLine("{0} ", i);
    }
    Console.WriteLine();
}

static void WhileLoopExample()
{
    Console.WriteLine("================ While Loop ================");
    string userIsDone = "";

    // Test on a lower-class copy of the string
    while (userIsDone.ToLower() != "yes")
    {
        Console.Write("Are you done? [yes] [no]: ");
        userIsDone = Console.ReadLine();
        Console.WriteLine("In while loop");
    }
    Console.WriteLine();
}

static void DoWhileLoopExample()
{
    Console.WriteLine("================ Do While Loop ================");

    string userIsDone = "";

    do
    {
        Console.WriteLine("In do/while loop");
        Console.Write("Are you done? [yes] [no]: ");
        userIsDone = Console.ReadLine();
    } while (userIsDone.ToLower() != "yes"); // Note the semicolon!
    Console.WriteLine();
}

static void IfElseExample()
{
    Console.WriteLine("================ If Else ================");

    // This was from the book, but it doesn't make sense with the if/else statements
    // string stringData = "My textual data";

    // My version
    Console.Write("Enter any words/numbers: ");
    string stringData = Console.ReadLine();
    if (stringData.Length > 0)
    {
        Console.WriteLine("String is greater than 0 characters");
    }
    else
    {
        Console.WriteLine("String is not greater than 0 characters");
    }
    Console.WriteLine();
}

static void IfElsePatternMatching()
{
    Console.WriteLine("================ If Else Pattern Matching ================");
    object testItem1 = 123;
    object testItem2 = "Hello";
    if (testItem1 is string myStringValue1)
    {
        Console.WriteLine($"{myStringValue1} is a string");
    }
    if (testItem1 is int myValue1)
    {
        Console.WriteLine($"{myValue1} is an int");
    }

    if (testItem2 is string myStringValue2)
    {
        Console.WriteLine($"{myStringValue2} is a string");
    }
    if (testItem2 is int myValue2)
    {
        Console.WriteLine($"{myValue2} is an int");
    }

    Console.WriteLine();
}

static void IfElsePatternMatchingUpdatedInCSharp9()
{
    Console.WriteLine("======= C# 9 If Else Pattern Matching Improvements =======");
    object testItem1 = 123;
    Type t = typeof(string);
    char c = 'f';

    // Type patterns
    if (t is Type)
    {
        Console.WriteLine($"{t} is a Type");
    }

    // Relational, Conjuctive, and Disjunctive patterns
    if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
    {
        Console.WriteLine($"{c} is a character");
    }

    // Parenthesized patterns
    if (c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',')
    {
        Console.WriteLine($"{c} is a character or seperator");
    }

    // Negative patterns
    if (testItem1 is not string)
    {
        Console.WriteLine($"{testItem1} is not a string");
    }
    if (testItem1 is not null)
    {
        Console.WriteLine($"{testItem1} is not null");
    }
    Console.WriteLine();
}

static void ExecuteIfElseUsingConditionlaOperator()
{
    string stringData = "My textual data";
    Console.WriteLine(stringData.Length > 0 
                      ? "string is greater than 0 characters" 
                      : "string is not greater than 0 characters");
    Console.WriteLine();
}

static void ConditionalRefExample()
{
    var smallArray = new int[] { 1, 2, 3, 4, 5 };
    var largeArray = new int[] { 10, 20, 30, 40, 50 };

    int index = 7;
    ref int refValue = ref ((index < 5) 
                             ? ref smallArray[index] 
                             : ref largeArray[index - 5]);
    
    refValue = 0;
    index = 2;
    ((index < 5)
      ? ref smallArray[index]
      : ref largeArray[index - 5]) = 100;
    
    Console.WriteLine(string.Join(" ", smallArray));
    Console.WriteLine(string.Join(" ", largeArray));
    Console.WriteLine();
}

static void LogicalOperatorsExample()
{
    Console.WriteLine("================ Logical Operators ===============");
    bool t = true;
    bool f = false;
    Console.WriteLine($"{t.ToString()} && {t.ToString()} = {t && t}"); //true
    Console.WriteLine($"{t.ToString()} && {f.ToString()} = {t && f}"); //false
    Console.WriteLine($"{t.ToString()} || {t.ToString()} = {t || t}"); //true
    Console.WriteLine($"{t.ToString()} || {f.ToString()} = {t || f}"); //true
    Console.WriteLine($"{f.ToString()} || {f.ToString()} = {f || f}"); //false
    Console.WriteLine($"!{t.ToString()} = {!t}"); //false
    Console.WriteLine($"!{f.ToString()} = {!f}"); //true
}

// Switch on a numerical value
static void SwitchExample()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.Write("Please pick your language preference: ");

    string langChoice = Console.ReadLine();
    int n = int.Parse(langChoice);

    switch (n)
    {
        case 1:
            Console.WriteLine("Good choice, C# is a fine language.");
            break;
        case 2:
            Console.WriteLine("VB: OOP, multithreading, and more!");
            break;
        default:
            Console.WriteLine("Well... good luck with that!");
            break;
    }
}

// Switch on string value
static void SwitchOnStringExample()
{
    Console.WriteLine("[C#] or [VB]");
    Console.Write("Please pick your language preference: ");

    string langChoice = Console.ReadLine();
    switch (langChoice.ToUpper())
    {
        case "C#":
            Console.WriteLine("Good choice, C# is a fine language.");
            break;
        case "VB":
            Console.WriteLine("VB: OOP, multithreading, and more!");
            break;
        default:
            Console.WriteLine("Well... good luck with that!");
            break;
    }
}

static void SwitchOnEnumExample()
{
    Console.Write("Enter your favorite day of the week: ");
    DayOfWeek favDay;
    try
    {
        favDay = (DayOfWeek) Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Bad input!");
        return;
    }
    switch (favDay)
    {
        case DayOfWeek.Sunday:
            Console.WriteLine("Football!!");
            break;
        case DayOfWeek.Monday:
            Console.WriteLine("Another day, another dollar");
            break;
        case DayOfWeek.Tuesday:
            Console.WriteLine("At least it isn't Monday...");
            break;
        case DayOfWeek.Wednesday:
            Console.WriteLine("A fine day");
            break;
        case DayOfWeek.Thursday:
            Console.WriteLine("Almost Friday...");
            break;
        case DayOfWeek.Friday:
            Console.WriteLine("Yes, Friday rules!");
            break;
        case DayOfWeek.Saturday:
            Console.WriteLine("Great day indeed...");
            break;
    }
    Console.WriteLine();
}

static void SwitchWithGoto()
{
    var foo = 5;
    switch(foo)
    {
        case 1:
            //do something
            goto case 2;
        case 2:
            //do something
            break;
        case 3:
            //yet another action
            goto default;
        default:
            //default action
            break;
    }
}

static void ExecutePatternMatchingSwitch()
{
    Console.WriteLine("================ Switch with Pattern Matching ================");

    Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
    Console.Write("Please choose an option: ");
    string userChoice = Console.ReadLine();
    object choice;
    // This is a standard constant pattern switch statement to set up the example
    switch(userChoice)
    {
        case "1":
            choice = 5;
            break;
        case "2":
            choice = "Hi";
            break;
        case "3":
            choice = 2.5M;
            break;
        default:
            choice = 5;
            break;
    }
    // This is new, the pattern matching switch statement
    switch (choice)
    {
        case int i:
            Console.WriteLine("Your choice is an integer {0}.", i);
            break;
        case string s:
            Console.WriteLine("Your choice is a string. {0}", s);
            break;
        case decimal d:
            Console.WriteLine("Your choice is a decimal. {0}", d);
            break;
        default:
            Console.WriteLine("Your choice is something else");
            break;
    }
    Console.WriteLine();
}

static void ExecutePatternMatchingSwitchWithWhen()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.Write("Please pick your language preference: ");

    object langChoice = Console.ReadLine();
    var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;

    switch (choice)
    {
        case int i when i == 2:
        case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("VB: OOP, multithreading, and more!");
            break;
        case int i when i == 1:
        case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("Good choice, C# is a fine language.");
            break;
        default:
            Console.WriteLine("Well... good luck with that!");
            break;
    }
    Console.WriteLine();
}

// Switch expression from C# 7, to compare against C# 8
static string FromRainbowClassic(string colorBand)
{
    switch (colorBand)
    {
        case "Red":
            return "#FF0000";
        case "Orange":
            return "#FF7F00";
        case "Yellow":
            return "#FFFF00";
        case "Green":
            return "#00FF00";
        case "Blue":
            return "#0000FF";
        case "Indigo":
            return "#4B0082";
        case "Violet":
            return "#9400D3";
        default:
            return "#FFFFFF";
    }
}

// Switch expression using lambda statments from C# 8, compare to above
static string FromRanbow(string colorBand)
{
    return colorBand switch
    {
        "Red" => "#FF0000",
        "Orange" => "#FF7F00",
        "Yellow" => "#FFFF00",
        "Green" => "#00FF00",
        "Blue" => "#0000FF",
        "Indigo" => "#4B0082",
        "Violet" => "9400D3",
        _ => "#FFFFFF",
    };
}

// Switch expression with Tuples
static string RockPaperScissors(string first, string second)
{
    return (first, second) switch
    {
        ("rock", "paper") => "Paper wins.",
        ("rock", "scissors") => "Rock wins.",
        ("paper", "rock") => "Paper wins.",
        ("paper", "scissors") => "Scissors wins,",
        ("scissors", "rock") => "Rock wins.",
        ("scissors", "paper") => "Scissors wins.",
        (_, _) => "Tie.",
    };
}

