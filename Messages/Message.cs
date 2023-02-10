using Penguin.Messaging.Abstractions.Interfaces;

namespace Penguin.Messaging.Abstractions.Messages
{
    /// <summary>
    /// Base message class required for automatically subscribing methods
    /// </summary>
    /// <typeparam name="T">The inner object type of the message</typeparam>
    public abstract class Message<T> : Message, IMessage<T>
    {
        #region Properties

        /// <summary>
        /// The object relevant to the message
        /// </summary>
        public new T Target { get => (T)base.Target; set => base.Target = value; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Constructs a new message and sets the target to the relevant object
        /// </summary>
        /// <param name="target">The object relevant to the message</param>
        protected Message(T target)
        {
            Target = target;
        }

        #endregion Constructors
    }

    /// <summary>
    /// Base message class required for automatically subscribing methods
    /// </summary>
    public abstract class Message : IMessage
    {
        public object Target { get; set; }

        object IMessage.Target => Target;
    }
}