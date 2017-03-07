using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;

namespace FisherInsuranceApi.Controllers {
[Route("api/quotes")]
public class QuotesController : Controller
{
        private readonly FisherContext db;

        public QuotesController(FisherContext context) 
        {
                db = context;
        }

// POST api/auto/quotes 
        
        [HttpPost] 
        public IActionResult Post([FromBody] Quote quote) 
        { 
            var newQuote = db.Quotes.Add(quote);
            db.SaveChanges();
            return CreatedAtRoute("GetQuote", new { id = quote.Id }, quote);
        }

// GET api/auto/quotes/5
        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            return Ok(db.Quotes.Find(id));
        }

// PUT api/auto/quotes/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Quote quote) {
            var newQuote = db.Quotes.Find(id); 
            if (newQuote == null)
                {
                   return NotFound();
                }
                newQuote = quote;
                db.SaveChanges();
                return Ok(newQuote);
        }

// DELETE api/auto/quotes/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
                var quoteToDelete = db.Quotes.Find(id);
                if (quoteToDelete == null)
        {
                return NotFound();
        }
                db.Quotes.Remove(quoteToDelete);
                db.SaveChangesAsync();
                return NoContent();
        }

// DELETE api/auto/quotes/
        [HttpGet]
        public IActionResult GetQuotes() 
        {
        return Ok(db.Quotes);
        }
 

}}

