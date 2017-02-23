using Microsoft.AspNetCore.Mvc;
using FisherInsuranceAPI.Data;

[Route("api/claims")] 
public class ClaimsController : Controller 
{ 
        private IMemoryStore db;

        public ClaimsController(IMemoryStore repo)
        {
            db = repo;
        }

    // POST api/claims
        [HttpPost] 
        public IActionResult Post([FromBody]string value) 
        { 
            return Created("", value); 
        }

        [HttpGet]
        public IActionResult GetQuotes()
        {
            return Ok(db.RetrieveAllQuotes);
        }
    // GET api/claims/5
        [HttpGet("{id}")] 
        public IActionResult Get(int id) 
        { 
           return Ok("The id is: " + id); 
        }
    // PUT api/claims/id 
        [HttpPut("{id}")] 
        public IActionResult Put(int id, [FromBody]string value) 
        { 
            return NoContent(); 
        }
    // DELETE api/claims/id 
        [HttpDelete("{id}")] 
        public IActionResult Delete(int id) 
        { 
            return Delete(id); 
        }
}