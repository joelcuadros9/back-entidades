namespace WebApiEntidades.Domain
{
    public interface IEntityRepository
    {
        Task<List<Entity>> GetEntitiesAsync();
    }
}
