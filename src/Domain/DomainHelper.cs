using Rocket.Surgery.Reflection.Extensions;

namespace Rocket.Surgery.Domain
{
    public static class DomainHelper
    {
        private static readonly BackingFieldHelper BackingFieldHelper = new BackingFieldHelper();

        public static void SetOwnerData<TKey>(IHaveOwner<TKey> owner, OwnerData<TKey> data)
        {
            BackingFieldHelper.SetBackingField(owner, x => x.Owner, data);
        }

        public static void SetCreatedData<TKey>(IHaveCreatedBy<TKey> owner, ChangeData<TKey> data)
        {
            BackingFieldHelper.SetBackingField(owner, x => x.Created, data);
        }

        public static void SetUpdatedData<TKey>(IHaveUpdatedBy<TKey> owner, ChangeData<TKey> data)
        {
            BackingFieldHelper.SetBackingField(owner, x => x.Updated, data);
        }

        public static void SetAssignedUsersData<TKey>(ICanBeAssigned<TKey> assigned, AssignedUsersData<TKey> data)
        {
            BackingFieldHelper.SetBackingField(assigned, x => x.AssignedUsers, data);
        }
    }
}
