using Games.API.Data;
using Games.API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Attribute = Games.API.Models.Domain.Attribute;

namespace Games.API.Controllers
{
    // https://localhost:5001/api/attrubutes
    [Route("api/[controller]")]
    [ApiController]
    public class AttrubutesController : ControllerBase
    {
        private GamesDbContext _dbContext;


        public AttrubutesController(GamesDbContext context)
        {
            _dbContext = context;
        }


        public IActionResult GetAll()
        {
            List<AttributeDto> attributeDtos = new List<AttributeDto>();
            if (_dbContext.Attributes == null || !_dbContext.Attributes.Any())
            {
                return NotFound("No attributes found.");
            }

            _dbContext.Attributes.ToList().ForEach(a => attributeDtos.Add(new AttributeDto(a)));

            return Ok(attributeDtos);
        }

        public IActionResult GetById(int id)
        {
            var attribute = _dbContext.Attributes.Find(id);

            if (attribute == null)
            {
                return NotFound();
            }

            var attributeDto = new AttributeDto(attribute);

            return Ok(attributeDto);
        }

        public IActionResult Create([FromBody] AttributeDto attributeDto)
        {
            if (attributeDto == null)
            {
                return BadRequest("Attribute cannot be null.");
            }
            var attribute = new Attribute(attributeDto);
            _dbContext.Attributes.Add(attribute);
            _dbContext.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = attribute.Id }, attribute);
        }

        public IActionResult Update(int id, [FromBody] AttributeDto attributeDto)
        {
            if (attributeDto == null || id != attributeDto.Id)
            {
                return BadRequest("Attribute is invalid.");
            }
            var existingAttribute = _dbContext.Attributes.Find(id);
            if (existingAttribute == null)
            {
                return NotFound();
            }
            existingAttribute.Name = attributeDto.Name;
            existingAttribute.AttributeType = attributeDto.AttributeType;
            _dbContext.SaveChanges();

            return NoContent();
        }

        public IActionResult Delete(int id)
        {
            var attribute = _dbContext.Attributes.Find(id);
            if (attribute == null)
            {
                return NotFound();
            }
            _dbContext.Attributes.Remove(attribute);
            _dbContext.SaveChanges();

            return NoContent();
        }
    }
}
