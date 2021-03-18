using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ISmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("SMS Loggandi");
        }
    }
}
