using SimpleClassExample;


Console.WriteLine("***** Fun with Class Types *****\n");

// Allocate and configure a Car object
Car myCar = new Car();
myCar.petName = "Henry";
myCar.currSpeed = 10;

// Speed up the car a few times and print out the new state
for (int i = 0; i <= 10; i++)
{
    myCar.SpeedUp(5);
    myCar.PrintState();
}
Console.ReadLine();

Console.WriteLine("***** Default Constructor *****\n");

// Chuck going 10 mph
Car chuck = new Car();
chuck.PrintState();

// Mary going 0 mph
Car mary = new Car("Mary");
mary.PrintState();

// Daisy going 75 mph
Car daisy = new Car("Daisy", 75);
daisy.PrintState();
Console.ReadLine();

Console.WriteLine("***** Fun with Motorcycles *****");

Motorcycle c = new Motorcycle(5);
c.SetDriverName("Tiny");
c.PopAWheely();
Console.WriteLine("Rider name is {0}", c.driverName);
MakeSomeBikes();
Console.ReadLine();

static void MakeSomeBikes()
{
    Motorcycle m1 = new Motorcycle();
    Console.WriteLine("Name= {0}, Intensity= {1}", m1.driverName, m1.driverIntensity);

    Motorcycle m2 = new Motorcycle(name: "Tiny");
    Console.WriteLine("Name= {0}, Intensity= {1}", m2.driverName, m2.driverIntensity);

    Motorcycle m3 = new Motorcycle(7);
    Console.WriteLine("Name= {0}, Intensity= {1}", m3.driverName, m3.driverIntensity);
}


