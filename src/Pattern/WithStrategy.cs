using System;

namespace Ioc.Pattern
{
    public interface ILanguage
    {
        #region Methods

        void SayBye();

        void SayHello();

        #endregion Methods
    }

    public class French : ILanguage
    {
        #region Methods

        public void SayBye() => Console.WriteLine("Bonjour.");

        public void SayHello() => Console.WriteLine("Au revoir");

        #endregion Methods
    }

    public class Spanish : ILanguage
    {
        #region Methods

        public void SayBye() => Console.WriteLine("Hola");

        public void SayHello() => Console.WriteLine("Adios");

        #endregion Methods
    }

    public class Speaker
    {
        #region Methods

        public void Speak(ILanguage language)
        {
            language.SayHello();
            language.SayBye();
        }

        #endregion Methods
    }

    public class WithStrategy 
    {
        #region Methods

        public void Show()
        {
            var speaker = new Speaker();

            speaker.Speak(new French());
        }

        #endregion Methods
    }
}