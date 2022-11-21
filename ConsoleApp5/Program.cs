using System;
namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            ILogger logger1 = new Logger1();
            ISumCount sumCount = new Result();
            ISubstarct substarct = new Result();
            Calculator calculator = new Calculator(substarct, sumCount);
            var result = new ChoosingAction(logger1, calculator);
            result.EnterNumber();
        }
    }
}



