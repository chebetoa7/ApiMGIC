using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiMGIC.Data.Entities;
using ApiMGIC.Model.Store;

namespace ApiMGIC.Controllers.ControllerBD
{
    [Route("api/[controller]")]
    [ApiController]
    public class storesController : Controller
    {
        private readonly DataContext _context;
        private readonly storeRepository storeRepository_;

        public storesController(DataContext context, storeRepository storeRepository)
        {
            _context = context;
            storeRepository_ = storeRepository;
        }

        // GET: api/stores
        [HttpGet]
        public IEnumerable<store> Getstores()
        {
            return _context.stores;
        }

        // GET: api/stores/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Getstore([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var store = await _context.stores.FindAsync(id);

            if (store == null)
            {
                return NotFound();
            }

            return Ok(store);
        }

        // PUT: api/stores/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putstore([FromRoute] string id, [FromBody] store store)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != store.idS)
            {
                return BadRequest();
            }

            _context.Entry(store).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!storeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        

        // POST: api/stores
       [HttpPost]
        public async Task<IActionResult> Poststore([FromBody] store store)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                else
                {
                    storeRepository_.Save(store);
                    //var result = _context.stores.Add(store);
                    //await _context.SaveChangesAsync();
                    return Ok(store);
                }
            } catch (Exception exM)
            {
                Console.WriteLine(exM.Message);
                throw;
            }
            

           // _context.stores.Add(store);
            //await _context.SaveChangesAsync();

            //return CreatedAtAction("Getstore", new { id = store.idS }, store);
        }

        // DELETE: api/stores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletestore([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var store = await _context.stores.FindAsync(id);
            if (store == null)
            {
                return NotFound();
            }

            _context.stores.Remove(store);
            await _context.SaveChangesAsync();

            return Ok(store);
        }

        private bool storeExists(string id)
        {
            return _context.stores.Any(e => e.idS == id);
        }
    }
}