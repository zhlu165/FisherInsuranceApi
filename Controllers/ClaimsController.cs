using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using FisherInsuranceApi.QuoteModel;
namespace FisherInsuranceApi.Controllers {
[Route("api/customercare/claims")]
public class ClaimsController : Controller
{

        private IMemoryStore db;
        public ClaimsController(IMemoryStore repo) 
        {
        db = repo;
        }

        [HttpGet] 
        public IActionResult GetQuotes() 
        { 
            return Ok(db.RetrieveAllQuotes); 
        }

// POST api/customercare/claims
        
        [HttpPost] 
        public IActionResult Post([FromBody] Quote quote) 
        { 
            return Ok(db.CreateQuote(quote)); 
        }

// GET api/customercare/claims/5
        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            return Ok(db.RetrieveClaim(id));
        }

// PUT api/customercare/claims/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Quote quote) {
            return Ok(db.UpdateQuote(quote));
        }

// DELETE api/customercare/claims/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromBody] Quote quote) {
             db.DeleteQuote(id);
             return Ok();
        }

}}

