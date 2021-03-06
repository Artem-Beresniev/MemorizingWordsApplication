﻿using System;
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
    public class LanguagesController : ApiController
    {
        private WordsMemorizingContext db = new WordsMemorizingContext();

        // GET api/Languages
        public IQueryable<Language> GetLanguages()
        {
            return db.Languages;
        }

        // GET api/Languages/5
        [ResponseType(typeof(Language))]
        public async Task<IHttpActionResult> GetLanguage(int id)
        {
            Language language = await db.Languages.FindAsync(id);
            if (language == null)
            {
                return NotFound();
            }

            return Ok(language);
        }

        // PUT api/Languages/5
        public async Task<IHttpActionResult> PutLanguage(int id, Language language)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != language.Id)
            {
                return BadRequest();
            }

            db.Entry(language).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LanguageExists(id))
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

        // POST api/Languages
        [ResponseType(typeof(Language))]
        public async Task<IHttpActionResult> PostLanguage(Language language)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Languages.Add(language);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = language.Id }, language);
        }

        // DELETE api/Languages/5
        [ResponseType(typeof(Language))]
        public async Task<IHttpActionResult> DeleteLanguage(int id)
        {
            Language language = await db.Languages.FindAsync(id);
            if (language == null)
            {
                return NotFound();
            }

            db.Languages.Remove(language);
            await db.SaveChangesAsync();

            return Ok(language);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LanguageExists(int id)
        {
            return db.Languages.Count(e => e.Id == id) > 0;
        }
    }
}