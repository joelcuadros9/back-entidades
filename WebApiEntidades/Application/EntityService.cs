using WebApiEntidades.Domain;

namespace WebApiEntidades.Application
{
    public class EntityService
    {
        private readonly IEntityRepository _repository;

        public EntityService(IEntityRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Entity>> GetEntitiesAsync()
        {
            return await _repository.GetEntitiesAsync();
        }
    }
}
