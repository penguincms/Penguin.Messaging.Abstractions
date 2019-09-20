using System;

namespace Penguin.Messaging.Abstractions.Interfaces
{
    /// <summary>
    /// This class denotes a class set to be automatically subscribed by the message handler when the SubscribeAll method is called
    /// </summary>
    [Obsolete("This non-generic interface should be avoided in favor of the generic version that forces better type safety", false)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1040:Avoid empty interfaces", Justification = "<Pending>")]
    public interface IMessageHandler
    {
    }
}