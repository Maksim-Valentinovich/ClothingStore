namespace ClothingStore.Domain.Common
{
    internal class Entity<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }

    internal class Entity : Entity<ulong>
    {

    }
}
