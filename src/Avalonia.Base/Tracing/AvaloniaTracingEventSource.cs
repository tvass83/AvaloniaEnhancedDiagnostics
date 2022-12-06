using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace Avalonia.Infrastructure.Tracing
{
    [EventSource(Name = "Avalonia.Win32.Tracing")]
    public sealed class AvaloniaTracingEventSource : EventSource
    {
        private AvaloniaTracingEventSource()
        {

        }

        [Event(1)]
        public void Enter(string fullMethodName)
        {
            WriteEvent(1, fullMethodName);
        }

        [Event(2)]
        public void Leave(string fullMethodName)
        {
            WriteEvent(2, fullMethodName);
        }

        [Event(3)]
        public void Info([CallerMemberName] string message = null)
        {
            WriteEvent(3, message);
        }

        public static AvaloniaTracingEventSource Log { get; } = new AvaloniaTracingEventSource();
    }
}
