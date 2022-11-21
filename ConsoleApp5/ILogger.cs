using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
     interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}
