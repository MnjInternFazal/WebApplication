using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationApi.Models;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationsController : ControllerBase
    {
        private readonly ApplicationContext context;

        public EducationsController(ApplicationContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Education>>> GetEducations()
        {
            return await context.Educations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Education>> GetEducation(int id)
        {
            var education = await context.Educations.FindAsync(id);
            if (education == null)
            {
                return NotFound();
            }
            return education;
        }

        [HttpPost]
        public async Task<ActionResult<Education>> PostEducation(Education education)
        {
            context.Educations.Add(education);
            await context.SaveChangesAsync();
            return CreatedAtAction("GetEducation", new { id = education.EducationId }, education);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEducation(int id, Education education)
        {
            if (id != education.EducationId)
            {
                return BadRequest();
            }
            context.Entry(education).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEducation(int id)
        {
            var education = await context.Educations.FindAsync(id);
            if (education == null)
            {
                return NotFound();
            }
            context.Educations.Remove(education);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
