using Api.Data;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly ContactAPIDbContext dbContext;
        public ContactsController(ContactAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        /*Annotate with httpget keyword*/
        public async Task<IActionResult> GetContacts()
        {
            return Ok(await dbContext.contacts.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddContact(AddContactRequest ccontact)
        {
            var contact = new Contact()
            {

                Address = ccontact.Address,
                Email = ccontact.Email,
                Fullname = ccontact.Fullname,
                Phone = ccontact.Phone
            };

            await dbContext.contacts.AddAsync(contact);
            await dbContext.SaveChangesAsync();
            return Ok(contact);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateContact([FromRoute] Guid id, UpdateContactRequest updatecontact)
        {
            var contact = await dbContext.contacts.FindAsync(id);
            if (contact != null)
            {
                contact.Fullname = updatecontact.Fullname;
                contact.Address = updatecontact.Address;
                contact.Email = updatecontact.Email;
                contact.Phone = updatecontact.Phone;

                await dbContext.SaveChangesAsync();
                return Ok(contact);
            }
            return NotFound();
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetContact([FromRoute] Guid id)
        {
            var contact = await dbContext.contacts.FindAsync(id);
            if (contact != null)
            {
                return Ok(contact);
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> DeleteContact([FromRoute] Guid id)
        {
            var contact = await dbContext.contacts.FindAsync(id);
            if (contact != null)
            {
                dbContext.contacts.Remove(contact);
                await dbContext.SaveChangesAsync();
                return Ok(contact);
            }
            return NotFound();
        }
    }
}
