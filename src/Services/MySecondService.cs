using Ioc.Infrastructure;
using Unity;

namespace Ioc.Services
{
    public class MySecondService
    {
        #region Properties

        [Dependency]
        public ILogService Log { get; set; }

        #endregion Properties

        #region Methods

        public void MyBehaviour()
        {
            Log.Warning("Hello world");
        }

        #endregion Methods
    }
}