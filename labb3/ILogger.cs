using System;


namespace labb3
{
    public interface ILogger : IDisposable
    {
        void Log(params string[] messages);
    }
}