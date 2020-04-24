using System;

namespace Ioc.Infrastructure
{
    public class BasicLogService
    {
        #region Methods

        public void Info(string message) => Console.WriteLine(message.ToLower());

        public void Warning(string message) => Console.WriteLine(message.ToUpper());

        #endregion Methods
    }
}