namespace Rocket.Surgery.Domain
{
    /// <summary>
    /// Interface ICanBeAssigned
    /// </summary>
    /// <typeparam name="TKey">The type of the t key.</typeparam>
    public interface ICanBeAssigned<TKey>
    {
        /// <summary>
        /// Gets the assigned users.
        /// </summary>
        /// <value>The assigned users.</value>
        AssignedUsersData<TKey> AssignedUsers { get; }
    }
}
