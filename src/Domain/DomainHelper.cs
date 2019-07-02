using JetBrains.Annotations;
using Rocket.Surgery.Reflection.Extensions;

namespace Rocket.Surgery.Domain
{
    /// <summary>
    /// DomainHelper.
    /// </summary>
    [PublicAPI]
    public static class DomainHelper
    {
        private static readonly BackingFieldHelper BackingFieldHelper = new BackingFieldHelper();

        /// <summary>
        /// Sets the owner data.
        /// </summary>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <param name="owner">The owner.</param>
        /// <param name="data">The data.</param>
        public static void SetOwnerData<TKey>(IHaveOwner<TKey> owner, OwnerData<TKey> data)
        {
            BackingFieldHelper.SetBackingField(owner, x => x.Owner, data);
        }

        /// <summary>
        /// Sets the created data.
        /// </summary>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <param name="owner">The owner.</param>
        /// <param name="data">The data.</param>
        public static void SetCreatedData<TKey>(IHaveCreatedBy<TKey> owner, ChangeData<TKey> data)
        {
            BackingFieldHelper.SetBackingField(owner, x => x.Created, data);
        }

        /// <summary>
        /// Sets the updated data.
        /// </summary>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <param name="owner">The owner.</param>
        /// <param name="data">The data.</param>
        public static void SetUpdatedData<TKey>(IHaveUpdatedBy<TKey> owner, ChangeData<TKey> data)
        {
            BackingFieldHelper.SetBackingField(owner, x => x.Updated, data);
        }

        /// <summary>
        /// Sets the assigned users data.
        /// </summary>
        /// <typeparam name="TKey">The type of the t key.</typeparam>
        /// <param name="assigned">The assigned.</param>
        /// <param name="data">The data.</param>
        public static void SetAssignedUsersData<TKey>(ICanBeAssigned<TKey> assigned, AssignedUsersData<TKey> data)
        {
            BackingFieldHelper.SetBackingField(assigned, x => x.AssignedUsers, data);
        }
    }
}
