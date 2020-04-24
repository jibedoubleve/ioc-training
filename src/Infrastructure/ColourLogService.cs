using System;
using System.Runtime.CompilerServices;

namespace Ioc.Infrastructure
{
    public class ColourLogService : ILogService
    {
        #region Methods

        public void Info(string message) => Write(message);

        public void Warning(string message) => Write(message);

        private void Write(string message, [CallerMemberName]string sender = null)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[{sender.ToUpper()}] {message}");
            Console.ResetColor();
        }

        #endregion Methods
    }
}