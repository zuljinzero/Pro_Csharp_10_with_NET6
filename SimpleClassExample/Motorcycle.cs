namespace SimpleClassExample;


class Motorcycle
{
    public int driverIntensity;
    public string driverName;



    // public string name;

    public void PopAWheely()
    {
        for (int i = 0; i <= driverIntensity; i++)
        {
            Console.WriteLine("Yeeeeeee Haaaaaeewww!");
        }
    }

    // Put back the defaul constructor, which will set all data members to default values
    public Motorcycle() {}

    // Our custom constructor
    public Motorcycle(int intensity = 0, string name = "")
    {
        Console.WriteLine("In main constructor ");
        if (intensity > 10)
        {
            intensity = 10;
        }
        driverIntensity = intensity;
        driverName = name;
    }

    public void SetDriverName(string name) => this.driverName = name;
}

