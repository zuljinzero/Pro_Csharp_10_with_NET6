using ObjectInitializers;


Console.WriteLine("***** Fun with Object Init Syntax *****\n");

// Make a Point by setting each property manually
Point firstPoint = new Point();
firstPoint.X = 10;
firstPoint.Y = 10;
firstPoint.DisplayStats();

// Make a Point via custom constructor
Point anotherPoint = new Point(20, 20);
anotherPoint.DisplayStats();

// Make a Point using object init syntax (implicitly)
Point finalPoint = new Point { X = 30, Y = 30 };
// ... (explicitly)
// Point finalPoint = new Point() { X = 30, Y = 30 };
finalPoint.DisplayStats();

// Calling a custom constructor
Point pt = new Point(10, 16) { X = 100, Y = 100 };

// Calling a more interesting custom constructor with init syntax
Point goldPoint = new Point(PointColorEnum.Gold) { X = 90, Y = 20 };
goldPoint.DisplayStats();

Console.WriteLine();

// Make a readonly Point after construction
PointReadOnlyAfterCreation firstReadOnlyPoint = new PointReadOnlyAfterCreation(20, 20);
firstReadOnlyPoint.DisplayStats();

// Make a Point using object init syntax
PointReadOnlyAfterCreation secondReadOnlyPoint = new PointReadOnlyAfterCreation { X = 30, Y = 30 };
secondReadOnlyPoint.DisplayStats();

Console.WriteLine();

// Create and initialize a Rectangle
Rectangle myRext = new Rectangle
{
    TopLeft = new Point { X = 10, Y = 10 },
    BottomRight = new Point { X = 200, Y = 200 }
};
myRext.DisplayStats();

Console.WriteLine();

