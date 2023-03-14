using static CodeHomeWork_3_2.Class1;
using static CodeHomeWork_3_2.Class2;

namespace CodeHomeWork_3_2;

class Program 
{
    static void Show(bool result)
    {
        Console.WriteLine(result);
    }

    static void Main(string[] args) 
    {
        Class1 class1 = new Class1();
        Class2 class2 = new Class2();

        Func<double, double, double> funcPow = class1.Pow;

        class2.Calc(funcPow, 2 , 3 );

        PowDelegate powDelegate = class2.Result;

        var result = powDelegate(4);

        ShowDelegate showDelegate = Show;

        showDelegate(result);
    }
}