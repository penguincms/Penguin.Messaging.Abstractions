namespace Penguin.Messaging.Abstractions.Interfaces
{
#pragma warning disable CS0618 // Type or member is obsolete

    /// <summary>
    /// This class denotes a class set to be automatically subscribed by the message handler when the SubscribeAll method is called
    /// </summary>
    public interface IMessageHandler<T> : IMessageHandler
#pragma warning restore CS0618 // Type or member is obsolete
    {
        /// <summary>
        /// Denotes that this method is used to accept messages from the message bus
        /// </summary>
        /// <param name="message">The message to accept</param>
        void AcceptMessage(T message);
    }

#pragma warning disable CS0618 // Type or member is obsolete

    /// <summary>
    /// This class denotes a class set to be automatically subscribed by the message handler when the SubscribeAll method is called
    /// </summary>
    public interface IMessageHandler<T1, T2> : IMessageHandler
#pragma warning restore CS0618 // Type or member is obsolete
    {
        /// <summary>
        /// Denotes that this method is used to accept messages from the message bus
        /// </summary>
        /// <param name="message">The message to accept</param>
        /// <param name="parameter">An additional object that is required along with the message</param>
        void AcceptMessage(T1 message, T2 parameter);
    }
}