using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        // Post: api/users
        [HttpPost]
        public IActionResult Post(CreateUserInputModel inputModel)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, inputModel);
        }

        // Put: api/users/cover
        [HttpPut("{id}/profile-picture")]
        public IActionResult PostProfilePicture(IFormFile file)
        {
            var description = $"File: {file.FileName}, Size: {file.Length}";

            // processar img

            return Ok(description);
        }

        // GetAt: api/users
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        // Get: api/users/1
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        // Put: api/users/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateUserInputModel inputModel)
        {
            return NoContent();
        }

        // DELETE: api/users/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
