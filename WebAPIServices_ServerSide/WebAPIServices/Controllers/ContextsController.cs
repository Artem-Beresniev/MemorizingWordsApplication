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
using EFModelsDAL.Models;
using EFModelsDAL;

namespace WebAPIServerSide.Controllers
{
    public class ContextsController : ApiController
    {
        private WordsMemorizingContext db = new WordsMemorizingContext();

        // GET api/Contexts
        public IQueryable<Context> GetContexts()
        {
            return db.Contexts;
        }

        // GET api/Contexts/5
        [ResponseType(typeof(Context))]
        public async Task<IHttpActionResult> GetContext(int id)
        {
            Context context = await db.Contexts.FindAsync(id);
            if (context == null)
            {
                return NotFound();
            }

            return Ok(context);
        }

        // PUT api/Contexts/5
        public async Task<IHttpActionResult> PutContext(int id, Context context)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != context.Id)
            {
                return BadRequest();
            }

            db.Entry(context).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContextExists(id))
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

        // POST api/Contexts
        [ResponseType(typeof(Context))]
        public async Task<IHttpActionResult> PostContext(Context context)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Contexts.Add(context);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ContextExists(context.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = context.Id }, context);
        }

        // DELETE api/Contexts/5
        [ResponseType(typeof(Context))]
        public async Task<IHttpActionResult> DeleteContext(int id)
        {
            Context context = await db.Contexts.FindAsync(id);
            if (context == null)
            {
                return NotFound();
            }

            db.Contexts.Remove(context);
            await db.SaveChangesAsync();

            return Ok(context);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ContextExists(int id)
        {
            return db.Contexts.Count(e => e.Id == id) > 0;
        }
    }
}