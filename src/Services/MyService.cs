using Ioc.Infrastructure;
using System;

namespace Ioc.Services
{
    public class MyService
    {
        #region Fields

        private readonly BasicLogService Log = new BasicLogService();

        #endregion Fields

        #region Methods

        public void SomeBehaviour()
        {
            Log.Warning("Keep attention here.");

            Console.WriteLine("\tStep 1");

            Log.Info("Some log message");

            Console.WriteLine("\tStep 2");
        }

        #endregion Methods
    }
}