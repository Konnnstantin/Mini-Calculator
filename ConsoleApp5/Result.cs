using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Result : ISumCount, ISubstarct
    {
        public void Substract()
        {
            try
            {
                double number1 = double.Parse(Console.ReadLine());
                double number2 = double.Parse(Console.ReadLine());
                var result = number1 - number2;
                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Не верный формат");
            }
        }

        public void SumNumber()
        {
            try
            {
                double number1 = double.Parse(Console.ReadLine());
                double number2 = double.Parse(Console.ReadLine());
                var result = number1 + number2;
                Console.WriteLine(result);
            }
            catch (FormatException)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Не верный формат");
            }

        }
    }


}
