namespace Rocket.Surgery.Domain
{
    public interface IHaveUpdatedBy<TKey>
    {
        ChangeData<TKey> Updated { get; }
    }
}
