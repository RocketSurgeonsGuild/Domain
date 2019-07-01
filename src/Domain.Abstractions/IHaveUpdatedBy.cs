namespace Rocket.Surgery.Domain
{
    /// <summary>
    ///  IHaveUpdatedBy
    /// </summary>
    /// <typeparam name="TKey">The type of the t key.</typeparam>
    public interface IHaveUpdatedBy<TKey>
    {
        /// <summary>
        /// Gets the updated.
        /// </summary>
        /// <value>The updated.</value>
        ChangeData<TKey> Updated { get; }
    }
}
