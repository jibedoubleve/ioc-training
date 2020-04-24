using System;

namespace Ioc.Pattern
{
    public abstract class BaseSpeaker
    {
        #region Methods

        protected abstract void SayGoodbye();

        protected abstract void SayHello();

        public void Speak()
        {
            SayHello();
            SayGoodbye();
        }

        #endregion Methods
    }

    public class DutchSpeaker : BaseSpeaker
    {
        #region Methods

        protected override void SayGoodbye() => Console.WriteLine("Tot ziens");

        protected override void SayHello() => Console.WriteLine("Hallo");

        #endregion Methods
    }

    public class EnglishSpeaker : BaseSpeaker
    {
        #region Methods

        protected override void SayGoodbye() => Console.WriteLine("Goodbye");

        protected override void SayHello() => Console.WriteLine("Hello");

        #endregion Methods
    }

    public class WithTemplateMethod
    {
        #region Methods

        public void Show()
        {
            BaseSpeaker ds = new DutchSpeaker();
            //BaseSpeaker ds = new EnglishSpeaker();
            ds.Speak();
        }

        #endregion Methods
    }
}