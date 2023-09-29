namespace BookStore.Data.Entities
{
    public interface IEntityBase<TKey>
    {
        TKey Id { get; set; }
    }

    public interface IEntityBase : IEntityBase<int> { }
}
