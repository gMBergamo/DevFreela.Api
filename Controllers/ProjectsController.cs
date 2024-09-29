using System.Net;
using Microsoft.AspNetCore.Mvc;
using DevFreela.API.Models;
using Microsoft.Extensions.Options;
using DevFreela.API.Services;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly FreelanceTotalCostConfig _config;
        private readonly IConfigService _configService;
        public ProjectsController(IOptions<FreelanceTotalCostConfig> options, IConfigService configService)
        {
            _config = options.Value;
            _configService = configService;
        }

        // GET: api/projects?search=crm
        [HttpGet]
        public IActionResult Get(string search = "")
        {
            return Ok(_configService.GetValue());
        }

        // GET: api/projects/1234
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            throw new Exception();
            
            return Ok();
        }

        // Post: api/projects
        [HttpPost]
        public IActionResult Post(CreateProjectInputModel inputModel)
        {
            if (inputModel.TotalCost < _config.Minimum || inputModel.TotalCost > _config.Maximum)
            {
                return BadRequest("Total cost must be between the minimum and maximum values.");
            }

            return CreatedAtAction(nameof(GetById), new { id = 1 }, inputModel);
        }

        // Put: api/projects/1234
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectInputModel inputModel)
        {
            return NoContent();
        }
        
        // DELETE: api/projects/1234
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

        // PUT api/projects/1234/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        // PUT api/projects/1234/complete
        [HttpPut("{id}/complete")]
        public IActionResult Complete(int id)
        {
            return NoContent();
        }

        // Post api/projects/1234/comments
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateProjectCommentInputModel inputModel)
        {
            return Ok();
        }
    }
}