using StaticDataAndMembers;


Console.WriteLine("***** Fun with Static Data *****\n");

SavingsAccount s1 = new SavingsAccount(50);
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

SavingsAccount.SetInterestRate(0.08);

SavingsAccount s2 = new SavingsAccount(100);
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

// Make a new object (Does NOT reset interest rate)
// SavingsAccount s3 = new SavingsAccount(10_000.75);
// Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

Console.ReadLine();


// These compile just fine
TimeUtilClass.PrintDate();
TimeUtilClass.PrintTime();

// Compiler error. Can't create instance of static classes
// TimeUtilClass u = new TimeUtilClass();

Console.ReadLine();



