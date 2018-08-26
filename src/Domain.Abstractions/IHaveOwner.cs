namespace Rocket.Surgery.Domain
{
    public interface IHaveOwner<TKey>
    {
        OwnerData<TKey> Owner { get; }
    }
}
