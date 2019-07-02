using JetBrains.Annotations;

namespace Rocket.Surgery.Domain
{
    /// <summary>
    ///  ICanBeAssigned
    /// </summary>
    /// <typeparam name="TKey">The type of the t key.</typeparam>
    [PublicAPI]
    public interface ICanBeAssigned<TKey>
    {
        /// <summary>
        /// Gets the assigned users.
        /// </summary>
        /// <value>The assigned users.</value>
        AssignedUsersData<TKey> AssignedUsers { get; }
    }
}
