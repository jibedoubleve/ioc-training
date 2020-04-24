using Ioc.Infrastructure;
using Unity;

namespace Ioc.Services
{
    public class YetAnotherService
    {
        #region Fields

        private ILogService _log;

        #endregion Fields

        #region Methods

        [InjectionMethod]
        public void Inject(ILogService log)
        {
            _log = log;
        }

        public void SomeBehaviour()
        {
            _log.Warning("Hello world with parameter injection");
        }

        #endregion Methods
    }
}