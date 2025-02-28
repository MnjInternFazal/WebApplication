using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationApi.Models;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly ApplicationContext context;

        public AddressesController(ApplicationContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Address>>> GetAddresses()
        {
            return await context.Addresses.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Address>> GetAddress(int id)
        {
            var address = await context.Addresses.FindAsync(id);
            if (address == null)
            {
                return NotFound();
            }
            return address;
        }

        [HttpPost]
        public async Task<ActionResult<Address>> PostAddress(Address address)
        {
            context.Addresses.Add(address);
            await context.SaveChangesAsync();
            return CreatedAtAction("GetAddress", new { id = address.AddressId }, address);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAddress(int id, Address address)
        {
            if (id != address.AddressId)
            {
                return BadRequest();
            }
            context.Entry(address).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var address = await context.Addresses.FindAsync(id);
            if (address == null)
            {
                return NotFound();
            }
            context.Addresses.Remove(address);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}

