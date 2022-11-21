using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Calculator : Result
    {
        ISumCount sumCount { get; }
        ISubstarct substarct { get; }
        public Calculator(ISubstarct substarct, ISumCount sumCount)
        {

            this.substarct = substarct;
            this.sumCount = sumCount;
        }

        public new void SumNumber()
        {
            try
            {
                Console.WriteLine("Введите число");
                sumCount.SumNumber();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public new void Substract()
        {
            try
            {
                Console.WriteLine("Введите число");
                substarct.Substract();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
