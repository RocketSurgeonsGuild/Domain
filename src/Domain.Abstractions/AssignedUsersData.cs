using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Rocket.Surgery.Domain
{
    /// <summary>
    /// AssignedUsersData.
    /// </summary>
    /// <typeparam name="TKey">The type of the t key.</typeparam>
    [PublicAPI]
    public class AssignedUsersData<TKey>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedUsersData{TKey}"/> class.
        /// </summary>
        /// <param name="userIds">The user ids.</param>
        [JsonConstructor]
        public AssignedUsersData(IEnumerable<TKey> userIds)
        {
            UserIds = new HashSet<TKey>(userIds);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedUsersData{TKey}"/> class.
        /// </summary>
        public AssignedUsersData()
        {
            UserIds = new HashSet<TKey>();
        }

        /// <summary>
        /// Gets the user ids.
        /// </summary>
        /// <value>The user ids.</value>
        public ISet<TKey> UserIds { get; }
    }
}
