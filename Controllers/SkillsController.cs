using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/skills")]
    public class SkillsController : ControllerBase
    {
        // GET: api/skills
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        // GET: api/skills/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // Post: api/skills
        [HttpPost]
        public IActionResult Post(CreateSkillInputModel inputModel)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, inputModel);
        }

        // Put: api/skills/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateSkillInputModel inputModel)
        {
            return NoContent();
        }

        // DELETE: api/skills/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

        // GET: api/skills/1/projects
        [HttpGet("{id}/projects")]
        public IActionResult GetProjects(int id)
        {
            return Ok();
        }

    }
} 