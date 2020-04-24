using Ioc.Infrastructure;
using Unity;

namespace Ioc.Services
{
    public class MyOtherService
    {
        #region Properties

        [Dependency]
        public ILogService Log { get; set; }

        #endregion Properties

        #region Methods

        public void SomeBehaviour()
        {
            Log.Warning("Hello world with property injection");
        }

        #endregion Methods
    }
}