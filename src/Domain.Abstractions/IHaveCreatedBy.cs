﻿namespace Rocket.Surgery.Domain
{
    /// <summary>
    ///  IHaveCreatedBy
    /// </summary>
    /// <typeparam name="TKey">The type of the t key.</typeparam>
    public interface IHaveCreatedBy<TKey>
    {
        /// <summary>
        /// Gets the created.
        /// </summary>
        /// <value>The created.</value>
        ChangeData<TKey> Created { get; }
    }
}
