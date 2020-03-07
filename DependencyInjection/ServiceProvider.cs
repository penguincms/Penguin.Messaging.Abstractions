using System;

namespace Penguin.Messaging.Abstractions.DependencyInjection
{
    /// <summary>
    /// A simple service provider class if nothing else is specified, that calls Activator.CreateInstance
    /// </summary>
    public class ServiceProvider : IServiceProvider
    {
        #region Methods

        /// <summary>
        /// Resolves the type by creating a new instance
        /// </summary>
        /// <param name="serviceType">The type to resolve</param>
        /// <returns>A new instance</returns>
        public object GetService(Type serviceType)
        {
            return Activator.CreateInstance(serviceType);
        }

        #endregion Methods
    }
}