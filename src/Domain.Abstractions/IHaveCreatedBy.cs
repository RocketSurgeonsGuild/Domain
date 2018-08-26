namespace Rocket.Surgery.Domain
{
    public interface IHaveCreatedBy<TKey>
    {
        ChangeData<TKey> Created { get; }
    }
}
