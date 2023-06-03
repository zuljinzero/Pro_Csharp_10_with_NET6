namespace SimpleClassExample;


class Car
{
    // The 'state' of the Car
    public string petName;
    public int currSpeed;

    // Custom default constructor
    public Car()
    {
        petName = "Chuck";
        currSpeed = 10;
    }

    // currSpeed will receive the default value of an int (zero)
    public Car(string pn) => petName = pn;

    // Let caller set the full state of the Car
    public Car(string pn, int cs)
    {
        petName = pn;
        currSpeed = cs;
    }

    public Car(string pn, int cs, out bool inDanger)
    {
        petName = pn;
        currSpeed = cs;
        if (cs > 100)
        {
            inDanger = true;
        }
        else
        {
            inDanger = false;
        }
    }

    // The functionality of the Car
    // Using expression-bodied member syntax (Covered in Chapter 4)
    public void PrintState() => Console.WriteLine("{0} is going {1} MPH", petName, currSpeed);

    public void SpeedUp(int delta) => currSpeed += delta;
}

