using Games.API.Data;
using Games.API.Models.Domain;
using Games.API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Games.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        GamesDbContext _dbContext;

        public DeveloperController(GamesDbContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var developers = _dbContext.Developers.ToList();
            if (developers == null || !developers.Any())
            {
                return NotFound("No developers found.");
            }
            var developerDtos = developers.Select(d => new DeveloperDto(d)).ToList();

            return Ok(developers);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var developer = _dbContext.Developers.Find(id);
            if (developer == null)
            {
                return NotFound();
            }
            var developerDto = new DeveloperDto(developer);

            return Ok(developerDto);
        }

        [HttpPost]
        public IActionResult Create([FromBody] DeveloperDto developerDto)
        {
            if (developerDto == null)
            {
                return BadRequest("Developer cannot be null.");
            }
            var developer = new Developer(developerDto);
            _dbContext.Developers.Add(developer);
            _dbContext.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = developer.Id }, new DeveloperDto(developer));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] DeveloperDto developerDto)
        {
            if (developerDto == null)
            {
                return BadRequest("Developer cannot be null.");
            }
            var existingDeveloper = _dbContext.Developers.Find(id);
            if (existingDeveloper == null)
            {
                return NotFound();
            }
            existingDeveloper.Name = developerDto.Name;
            existingDeveloper.Description = developerDto.Description;
            existingDeveloper.Url = developerDto.Url;
            existingDeveloper.Notes = developerDto.Notes ?? new List<Note>();
            _dbContext.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var developer = _dbContext.Developers.Find(id);
            if (developer == null)
            {
                return NotFound();
            }
            _dbContext.Developers.Remove(developer);
            _dbContext.SaveChanges();

            return NoContent();
        }
    }
}
