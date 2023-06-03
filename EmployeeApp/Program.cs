using EmployeeApp;


Console.WriteLine("***** Fun with Encapsulation*****\n");

Employee emp = new Employee("Marvin", 45, 123, 1000, "111-11-1111", EmployeePayTypeEnum.Salaried);
Console.WriteLine(emp.Pay);
emp.GiveBonus(100);
Console.WriteLine(emp.Pay);

// Employee emp = new Employee("Marvin", 456, 30_000);
// emp.GiveBonus(1000);
emp.DisplayStats();

// Use the get/set methods to interact with the object's name
// emp.Name = "Marv";
// Console.WriteLine("Employee name: {0}", emp.Name);
// Console.ReadLine();

// Name longer than 15 characters, error will print
// Employee emp2 = new Employee();
// emp2.SetName("Xena the warrior princess");
// Console.ReadLine();

