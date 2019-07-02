using Newtonsoft.Json;
using NodaTime;
using System;
using JetBrains.Annotations;

namespace Rocket.Surgery.Domain
{
    /// <summary>
    /// ChangeData.
    /// </summary>
    /// <typeparam name="TKey">The type of the t key.</typeparam>
    [PublicAPI]
    public class ChangeData<TKey>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeData{TKey}"/> class.
        /// </summary>
        /// <param name="by">The by.</param>
        /// <param name="at">At.</param>
        [JsonConstructor]
        public ChangeData(TKey by, Instant? at)
        {
            By = by;
            At = at;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeData{TKey}"/> class.
        /// </summary>
        /// <param name="by">The by.</param>
        /// <param name="at">At.</param>
        public ChangeData(TKey by, DateTimeOffset? at)
        {
            By = by;
            if (at.HasValue)
            {
                At = Instant.FromDateTimeOffset(at.Value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeData{TKey}"/> class.
        /// </summary>
        public ChangeData() { }

        /// <summary>
        /// Gets the by.
        /// </summary>
        /// <value>The by.</value>
        public TKey By { get; }

        /// <summary>
        /// Gets at.
        /// </summary>
        /// <value>At.</value>
        public Instant? At { get; }
    }
}
