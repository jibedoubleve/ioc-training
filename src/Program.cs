using Ioc.Services;
using System;

namespace Ioc
{
    internal class Program
    {
        #region Methods

        private static void Main(string[] args)
        {
            var service = new MyService();
            service.SomeBehaviour();

            #region Spoiler

            //var e = new WithTemplateMethod();
            //var e = new WithStrategy();
            //e.Show();

            #endregion Spoiler

            //---------------
            Console.WriteLine("Press <ENTER> to continue...");
            Console.ReadKey();
        }

        #endregion Methods
    }
}