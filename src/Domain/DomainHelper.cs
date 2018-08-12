using Rocket.Surgery.Reflection.Extensions;

namespace Rocket.Surgery.Domain
{
    public static class DomainHelper
    {
        private static readonly BackingFieldHelper BackingFieldHelper = new BackingFieldHelper();

        public static void SetOwnerData(IHaveOwner owner, OwnerData data)
        {
            BackingFieldHelper.SetBackingField(owner, x => x.Owner, data);
        }

        public static void SetCreatedData(IHaveCreatedBy owner, ChangeData data)
        {
            BackingFieldHelper.SetBackingField(owner, x => x.Created, data);
        }

        public static void SetUpdatedData(IHaveUpdatedBy owner, ChangeData data)
        {
            BackingFieldHelper.SetBackingField(owner, x => x.Updated, data);
        }

        public static void SetAssignedUsersData(ICanBeAssigned assigned, AssignedUsersData data)
        {
            BackingFieldHelper.SetBackingField(assigned, x => x.AssignedUsers, data);
        }
    }
}
