using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApiEntidades.Application;
using WebApiEntidades.Domain;

namespace WebApiEntidades.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class EntityController : ControllerBase
    {
        private readonly EntityService _service;

        public EntityController(EntityService service)
        {
            _service = service;
        }

        [EnableCors("AllowSpecificOrigins")]
        [HttpGet]
        public async Task<ActionResult<List<Entity>>> GetEntities()
        {
            try
            {
                var entities = await _service.GetEntitiesAsync();
                return Ok(entities);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }

}
