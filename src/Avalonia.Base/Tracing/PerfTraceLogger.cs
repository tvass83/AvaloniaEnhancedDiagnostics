using System;
using System.Runtime.CompilerServices;

namespace Avalonia.Infrastructure.Tracing
{
    public sealed class PerfTraceLogger<T> : IDisposable
    {
        private readonly string _method;

        public PerfTraceLogger([CallerMemberName] string method = null)
        {
            _method = typeof(T).ToString() + "." + method;

            AvaloniaTracingEventSource.Log.Enter(_method);
        }

        public void Dispose()
        {
            AvaloniaTracingEventSource.Log.Leave(_method);
        }
    }
}
