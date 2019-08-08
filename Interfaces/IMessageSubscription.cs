using System;
using System.Collections.Generic;

namespace Penguin.Messaging.Abstractions.Interfaces
{
    /// <summary>
    /// Interface used to define a new kind of reciever for messages
    /// </summary>
    public interface IMessageSubscription
    {
        #region Properties

        /// <summary>
        /// An ordered list of parameters that needs to be matched for the message to be recieved
        /// </summary>
        IEnumerable<Type> Parameters { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// The method called when a match is found, used to trigger execution of the message handler
        /// </summary>
        /// <param name="objects">The incoming parameters for the message</param>
        /// <param name="provider">The service provider to be used for creating any instances of classes recieving the message</param>
        void Invoke(object[] objects, IServiceProvider provider);

        #endregion Methods
    }
}