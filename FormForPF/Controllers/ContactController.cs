using Microsoft.AspNetCore.Mvc;
using FormForPF.Models;
using FormForPF.Models;

namespace ContactFormApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ContactForm contact)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();

            return Ok(new { success = true, message = "Данные сохранены!" });
        }
    }
}