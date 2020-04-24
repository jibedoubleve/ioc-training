using Unity;

namespace Ioc.UnityContainer
{
    public abstract class Bootstrapper
    {
        #region Properties

        protected static IUnityContainer Container { get; } = new Unity.UnityContainer();

        #endregion Properties

        #region Methods

        public void Start<TStartup>() where TStartup : IRunnable
        {
            Setup();
            Kickoff<TStartup>();
        }

        protected abstract void Kickoff<TStartup>() where TStartup : IRunnable;

        protected abstract void Setup();

        #endregion Methods
    }
}