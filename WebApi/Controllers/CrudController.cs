using Microsoft.AspNetCore.Mvc;
using ServiceContracts.Services;

namespace WebApi.Controllers;

public class CrudController<TEntity> : ControllerBase where TEntity : class
{
    private readonly ICrudService<TEntity> _entityService;

    public CrudController(ICrudService<TEntity> service)
    {
        _entityService = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<TEntity>>> GetAllAsync()
    {
        try
        {
            return await _entityService.GetAllAsync();
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                new { message = "An error occurred while processing your request." });
        }
    }

    [HttpPost]
    public async Task<ActionResult<TEntity>> CreateAsync([FromBody] TEntity entity)
    {
        try
        {
            return await _entityService.AddAsync(entity);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                new { message = "An error occurred while processing your request." });
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<TEntity>> GetByIdAsync(int id)
    {
        var entity = await _entityService.Get(id);

        if (entity == null)
        {
            return NotFound();
        }

        return entity;
    }


    [HttpPut("{id:int}")]
    public async Task<ActionResult<TEntity>> UpdateAsync(int id, [FromBody] TEntity entity)
    {
        var idProperty = typeof(TEntity).GetProperty("Id");

        if (idProperty == null)
        {
            return BadRequest("Entity does not have an Id property.");
        }

        idProperty.SetValue(entity, id);

        var updatedEntity = await _entityService.UpdateAsync(entity);

        return Ok(updatedEntity);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<TEntity>> DeleteAsync(int id)
    {
        return await _entityService.DeleteAsync(id);
    }
}