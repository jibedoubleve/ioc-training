using Ioc.Services;
using Unity;

namespace Ioc.Pattern
{
    public class WithDependencyInjection
    {
        #region Methods

        public void Show()
        {
            var c = new UnityContainer();
            //c.RegisterType<ILogService, BasicLogService>();

            var s1 = c.Resolve<MyService>();
            s1.SomeBehaviour();

            var s2 = c.Resolve<MyOtherService>();
            s2.SomeBehaviour();

            var s3 = c.Resolve<YetAnotherService>();
            s3.SomeBehaviour();
        }

        #endregion Methods
    }
}