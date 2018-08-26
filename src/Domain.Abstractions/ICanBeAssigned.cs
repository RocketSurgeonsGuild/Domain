namespace Rocket.Surgery.Domain
{
    public interface ICanBeAssigned<TKey>
    {
        AssignedUsersData<TKey> AssignedUsers { get; }
    }
}
