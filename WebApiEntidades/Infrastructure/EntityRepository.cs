using System.Text.Json;
using WebApiEntidades.Domain;

namespace WebApiEntidades.Infrastructure
{
    public class EntityRepository : IEntityRepository
    {
        private readonly string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Entities.txt");

        public async Task<List<Entity>> GetEntitiesAsync()
        {
            var jsonString = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<Entity>>(jsonString);
        }
    }

}
