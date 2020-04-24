using Ioc.Infrastructure;
using Ioc.UnityContainer;
using Unity;

namespace Ioc
{
    public class MyBootstrap : Bootstrapper
    {
        #region Fields


        #endregion Fields

        #region Methods

        protected override void Kickoff<TStartup>()
        {
            var app = Container.Resolve<TStartup>() as IRunnable;
            app.Run();
        }

        protected override void Setup()
        {
            Container.RegisterType<ILogService, ColourLogService>();
        }

        #endregion Methods
    }
}