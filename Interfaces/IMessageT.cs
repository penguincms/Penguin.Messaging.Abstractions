namespace Penguin.Messaging.Abstractions.Interfaces
{
    /// <summary>
    /// Base message interface required for automatically subscribing methods
    /// </summary>
    /// <typeparam name="T">The inner object type of the message</typeparam>
    public interface IMessage<out T> : IMessage
    {
        /// <summary>
        /// The object relevant to the message
        /// </summary>
        T Target { get; }
    }
}