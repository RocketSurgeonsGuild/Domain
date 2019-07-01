using System;
using Newtonsoft.Json;

namespace Rocket.Surgery.Domain
{
    /// <summary>
    /// OwnerData.
    /// </summary>
    /// <typeparam name="TKey">The type of the t key.</typeparam>
    public class OwnerData<TKey>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OwnerData{TKey}"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        [JsonConstructor]
        public OwnerData(TKey id)
        {
            Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OwnerData{TKey}"/> class.
        /// </summary>
        public OwnerData() { }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public TKey Id { get; }
    }
}
