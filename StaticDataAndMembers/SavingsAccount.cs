namespace StaticDataAndMembers;


class SavingsAccount
{
    // Instance-level data
    public double currBalance;
    public static double currInterestRate;

    public SavingsAccount(double balance)
    {
        currBalance = balance;
    }

    // STATIC CONSTRUCTOR RULES //
    // - A given class may define only a single static constructor (Can't be overloaded)
    // - Does not take an access modifier and can't take any parameters
    // - Executes exactly one time, regardless of how many objects of the type are created
    // - Runtime invokes the static constructor when it creates an instance of the class
    // --- or before accessing the first static member invoked by the caller
    // - Executes before any instance-level constructors
    // END RULES //

    // Static Constucror that runs once the first time SavingsAccount() is called
    // Allows for the changing of currInterestRate via SetInterestRate - Which wouldn't be able to change otherwise
    static SavingsAccount()
    {
        Console.WriteLine("In static constructor!");
        currInterestRate = 0.04;
    }

    // Static members to get/set interest rate
    public static void SetInterestRate(double newRate) => currInterestRate = newRate;
    public static double GetInterestRate() => currInterestRate;
}

