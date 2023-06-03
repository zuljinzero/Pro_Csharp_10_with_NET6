namespace EmployeeApp;


class Employee
{
    // Field data
    private string _empName;
    private int _empId;
    private float _currPay;
    private int _empAge;
    private string _empSSN;
    private DateTime _hireDate;

    // Constructors
    private EmployeePayTypeEnum _payType;
    public EmployeePayTypeEnum PayType
    {
        get => _payType;
        set => _payType = value;
    }

    public Employee() {}
    public Employee(string name, int id, float pay, string empSSN) 
        : this(name, 0, id, pay, empSSN, EmployeePayTypeEnum.Salaried){}
    public Employee(string name, int age, int id, float pay, string empSSN, 
        EmployeePayTypeEnum payType)
    {
        Name = name;
        Age = age;
        Id = id;
        Pay = pay;
        SocialSecurityNumber = empSSN;
        PayType = payType;
    }

    

    // Methods
    public void GiveBonus(float amount)
    {
        Pay = this switch
        {
            { Age: >= 18, PayType: EmployeePayTypeEnum.Commission, HireDate.Year: > 2020 }
                => Pay += .10F * amount,
            { Age: >= 18, PayType: EmployeePayTypeEnum.Hourly, HireDate.Year: > 2020 }
                => Pay += 40F * amount/2080F,
            { Age: >= 18, PayType: EmployeePayTypeEnum.Salaried, HireDate.Year: > 2020 }
                => Pay += amount,
              _ => Pay += 0
        };
    }

    // Updated DisplayStats() now accounts for age
    public void DisplayStats()
    {
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("ID: {0}", Id);
        Console.WriteLine("Age: {0}", Age);
        Console.WriteLine("Pay: {0}", Pay);
    }

    // Properties
    public string Name
    {
        get { return _empName; }
        set
        {
            if (value.Length > 15)
            {
                Console.WriteLine("Erro! Name length exceeds 15 characters!");
            }
            else
            {
                _empName = value;
            }
        }
    }
    public int Id
    {
        get { return _empId; }
        set { _empId = value; }
    }
    public float Pay
    {
        get { return _currPay; }
        set { _currPay = value; }
    }
    public int Age
    {
        get { return _empAge; }
        set { _empAge = value; }
    }
    // Readonly
    public string SocialSecurityNumber
    {
        get => _empSSN;
        private set => _empSSN = value;
    }
    public DateTime HireDate
    {
        get => _hireDate;
        set => _hireDate = value;
    }
}