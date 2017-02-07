using Microsoft.AspNetCore.Mvc;

namespace FisherInsuranceApi.Controllers {
[Route("api/customercare/claims")]
public class ClaimsController : Controller
{
// POST api/customercare/claims
        
        [HttpPost] 
        public IActionResult Post([FromBody]string value) 
        { 
            return Created("", value); 
        }

// GET api/customercare/claims/5
        [HttpGet("{id}")]
        public IActionResult Get(int id) {
            return Ok("The id is: " + id);
        }

// PUT api/customercare/claims/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]string value) {
            return NoContent();
        }

// DELETE api/customercare/claims/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            return Delete(id);
        }

}}

