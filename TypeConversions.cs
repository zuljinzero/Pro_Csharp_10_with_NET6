Console.WriteLine("***** Fun with Type Conversions *****");

// Add two shorts and print the results
// short num1 = 9, num2 = 10;
// Console.WriteLine("{0} + {1} = {2}", num1, num2, Add(num1, num2));

short num1 = 30_000, num2 = 30_000;
// This raises a compiler error
//short answer = Add(num1, num2);

// Explicitly cast the int into a short (and allow loss of data)
short answer = (short)Add(num1, num2);
Console.WriteLine("{0} + {1} = {2} (This is a loss of data error)", num1, num2, answer);
Console.WriteLine();

NarrowingAttempt();
ProcessBytes();
NarrowWithConvert();
Console.ReadLine();

// Short can convert to int without data loss because the range of short(32,767) - 
// Can easily fit within the range of int(2,147,483,647)
static int Add(int x, int y) => x + y;

static void NarrowingAttempt()
{
    byte myByte = 0;
    int myInt = 200;

    // Explicitly cast the int into a byte (no loss of data)
    myByte = (byte)myInt;
    Console.WriteLine("Value of myByte: {0} (No loss of data)", myByte);
}

static void ProcessBytes()
{
    byte b1 = 100;
    byte b2 = 250;

    // This time, tell the compilerto add CIL code
    // to throw an exception if overflow/underflow
    try
    {
        byte sum = checked((byte)Add(b1, b2));
        Console.WriteLine("sum = {0}", sum);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

static void NarrowWithConvert()
{
    byte myByte = 0;
    int myInt = 200;
    myByte = Convert.ToByte(myInt);
    Console.WriteLine("Value of myByte: {0}", myByte);
}

