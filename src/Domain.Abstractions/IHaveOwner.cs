using JetBrains.Annotations;

namespace Rocket.Surgery.Domain
{
    /// <summary>
    ///  IHaveOwner
    /// </summary>
    /// <typeparam name="TKey">The type of the t key.</typeparam>
    [PublicAPI]
    public interface IHaveOwner<TKey>
    {
        /// <summary>
        /// Gets the owner.
        /// </summary>
        /// <value>The owner.</value>
        OwnerData<TKey> Owner { get; }
    }
}
