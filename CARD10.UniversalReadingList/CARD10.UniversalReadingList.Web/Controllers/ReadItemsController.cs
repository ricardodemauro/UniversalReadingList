using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using CARD10.UniversalReadingList.Models;
using CARD10.UniversalReadingList.Web.Models;

namespace CARD10.UniversalReadingList.Web.Controllers
{
    public class ReadItemsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/ReadItems
        public IQueryable<ReadItem> GetReadItems()
        {
            return db.ReadItems;
        }

        // GET: api/ReadItems/5
        [ResponseType(typeof(ReadItem))]
        public async Task<IHttpActionResult> GetReadItem(int id)
        {
            ReadItem readItem = await db.ReadItems.FindAsync(id);
            if (readItem == null)
            {
                return NotFound();
            }

            return Ok(readItem);
        }

        // PUT: api/ReadItems/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutReadItem(int id, ReadItem readItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != readItem.Id)
            {
                return BadRequest();
            }

            db.Entry(readItem).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReadItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ReadItems
        [ResponseType(typeof(ReadItem))]
        public async Task<IHttpActionResult> PostReadItem(ReadItem readItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ReadItems.Add(readItem);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = readItem.Id }, readItem);
        }

        // DELETE: api/ReadItems/5
        [ResponseType(typeof(ReadItem))]
        public async Task<IHttpActionResult> DeleteReadItem(int id)
        {
            ReadItem readItem = await db.ReadItems.FindAsync(id);
            if (readItem == null)
            {
                return NotFound();
            }

            db.ReadItems.Remove(readItem);
            await db.SaveChangesAsync();

            return Ok(readItem);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReadItemExists(int id)
        {
            return db.ReadItems.Count(e => e.Id == id) > 0;
        }
    }
}