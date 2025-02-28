using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationApi.Models;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalDetailController : ControllerBase
    {
        private readonly ApplicationContext context;

        public PersonalDetailController(ApplicationContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<PersonalDetail>>> GetEmployees()
        {
            var data = await context.PersonalDetails.ToListAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PersonalDetail>> GetPersonalDetail(int id)
        {
            var personalDetail = await context.PersonalDetails.FindAsync(id);
            if (personalDetail == null)
            {
                return NotFound();
            }
            return personalDetail;
        }

        [HttpPost]
        public async Task<ActionResult<PersonalDetail>> PostPersonalDetail(PersonalDetail personalDetail)
        {
            context.PersonalDetails.Add(personalDetail);
            await context.SaveChangesAsync();
            return CreatedAtAction("GetPersonalDetail", new { id = personalDetail.PersonalId }, personalDetail);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonalDetail(int id, PersonalDetail personalDetail)
        {
            if (id != personalDetail.PersonalId)
            {
                return BadRequest();
            }
            context.Entry(personalDetail).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonalDetail(int id)
        {
            var personalDetail = await context.PersonalDetails.FindAsync(id);
            if (personalDetail == null)
            {
                return NotFound();
            }
            context.PersonalDetails.Remove(personalDetail);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}

