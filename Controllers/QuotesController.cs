using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.QuoteModel;

namespace FisherInsuranceApi.Controllers {
[Route("api/quotes")]
public class QuotesController : Controller
{
        private IMemoryStore db;
        public QuotesController(IMemoryStore repo) 
        {
        db = repo;
        }
 
// POST api/auto/quotes 
        
        [HttpPost] 
        public IActionResult Post([FromBody] Quote quote) 
        { 
            return Ok(db.CreateQuote(quote));
        }

// GET api/auto/quotes/5
        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            return Ok(db.RetrieveQuote(id));
        }

// PUT api/auto/quotes/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Quote quote) {
            return Ok(db.UpdateQuote(quote));
        }

// DELETE api/auto/quotes/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromBody] Quote quote) {
        db.DeleteQuote(id); 
        return Ok();
        }

        [HttpGet]
        public IActionResult GetQuotes() {
        return Ok(db.RetrieveAllQuotes);
        }
 

}}

