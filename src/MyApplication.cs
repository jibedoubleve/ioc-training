using Ioc.Infrastructure;
using Ioc.Services;
using Ioc.UnityContainer;

namespace Ioc
{
    public class MyApplication : IRunnable
    {
        #region Fields

        private readonly MyService _myService;

        #endregion Fields

        #region Constructors

        public MyApplication(MyService myService)
        {
            _myService = myService;
        }

        #endregion Constructors

        #region Methods

        public void Run()
        {
            _myService.SomeBehaviour();
        }

        #endregion Methods
    }
}