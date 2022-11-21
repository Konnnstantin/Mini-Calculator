using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Work : IWork
    {
        ILogger logger { get; }
        public Work(ILogger logger)
        {
            this.logger = logger;
        }

        public void Worker()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            logger.Event("Событие");
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Red;
            logger.Error("Ошибка");
        }
    }
}
