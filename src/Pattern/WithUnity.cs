using Ioc.Services;
using Unity;

namespace Ioc.Pattern
{
    public class WithUnity
    {
        #region Methods

        public void Show()
        {
            var c = new UnityContainer();

            var s = c.Resolve<MyService>();
            s.SomeBehaviour();
        }

        #endregion Methods
    }
}