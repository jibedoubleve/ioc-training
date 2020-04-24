namespace Ioc.Infrastructure
{
    public interface ILogService
    {
        #region Methods

        void Info(string message);

        void Warning(string message);

        #endregion Methods
    }
}