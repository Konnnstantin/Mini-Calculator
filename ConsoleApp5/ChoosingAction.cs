using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class ChoosingAction
    {
        Calculator calculator { get; }
        ILogger logger1 { get; }
        public ChoosingAction(ILogger logger1, Calculator calculator)
        {
            this.calculator = calculator;
            this.logger1 = logger1;
        }
        public void EnterNumber()
        {
            logger1.Event("Введите значение 1 для сложения цифр или 2 для вычитания цифр");
            int num = int.Parse(Console.ReadLine());
            try
            {
                if (num != 1 && num != 2) throw new Exception();
            }
            catch (FormatException)
            {
                logger1.Error("Не верный формат");
            }
            catch (Exception)
            {
                logger1.Error("Не правильно введено значение");
            }
            if (num == 1)
            {
                calculator.SumNumber();
            }
            else if (num == 2)
            {
                calculator.Substract();
            }
        }

    }
}
