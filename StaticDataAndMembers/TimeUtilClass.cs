using static System.Console;
using static System.DateTime;

namespace StaticDataAndMembers;


// Static classes can only contain static members
static class TimeUtilClass
{
    public static void PrintTime() => WriteLine(DateTime.Now.ToShortTimeString());
    public static void PrintDate() => WriteLine(DateTime.Today.ToShortDateString());
}

