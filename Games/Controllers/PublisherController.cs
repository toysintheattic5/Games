using Games.API.Data;
using Games.API.Models.Domain;
using Games.API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Games.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        GamesDbContext _dbContext;

        public PublisherController(GamesDbContext context)
        {
            _dbContext = context;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var publishers = _dbContext.Publishers.ToList();
            if (publishers == null || !publishers.Any())
            {
                return NotFound("No publishers found.");
            }
            var PublisherDtos = publishers.Select(d => new PublisherDto(d)).ToList();

            return Ok(publishers);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var Publisher = _dbContext.Publishers.Find(id);
            if (Publisher == null)
            {
                return NotFound();
            }
            var PublisherDto = new PublisherDto(Publisher);

            return Ok(PublisherDto);
        }

        [HttpPost]
        public IActionResult Create([FromBody] PublisherDto PublisherDto)
        {
            if (PublisherDto == null)
            {
                return BadRequest("Publisher cannot be null.");
            }
            var Publisher = new Publisher(PublisherDto);
            _dbContext.Publishers.Add(Publisher);
            _dbContext.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = Publisher.Id }, new PublisherDto(Publisher));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] PublisherDto PublisherDto)
        {
            if (PublisherDto == null)
            {
                return BadRequest("Publisher cannot be null.");
            }
            var existingPublisher = _dbContext.Publishers.Find(id);
            if (existingPublisher == null)
            {
                return NotFound();
            }
            existingPublisher.Name = PublisherDto.Name;
            existingPublisher.Description = PublisherDto.Description;
            existingPublisher.Url = PublisherDto.Url;
            existingPublisher.Notes = PublisherDto.Notes ?? new List<Note>();
            _dbContext.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Publisher = _dbContext.Publishers.Find(id);
            if (Publisher == null)
            {
                return NotFound();
            }
            _dbContext.Publishers.Remove(Publisher);
            _dbContext.SaveChanges();

            return NoContent();
        }
    }
}
