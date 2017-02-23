using FisherInsuranceAPI.Data;
using FisherInsuranceAPI.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/quotes")] 
public class QuotesController : Controller 
{ 
        private IMemoryStore db;

        public QuotesController(IMemoryStore repo)
        {
            db = repo;
        }

        [HttpGet]
        public IActionResult GetQuotes()
        {
            return Ok(db.RetrieveAllQuotes);
        }
    // POST api/quotes 
        [HttpPost] 
        public IActionResult Post([FromBody] Quote quote) 
        { 
            return Ok(db.CreateQuote(quote));
        }
    // GET api/quotes/5
        [HttpGet("{id}")] 
        public IActionResult Get(int id) 
        { 
           return Ok(db.RetrieveQuote(id));
        }
    // PUT api/quotes/id 
        [HttpPut("{id}")] 
        public IActionResult Put([FromBody] Quote quote) 
        { 
            return Ok(db.UpdateQuote(quote));
        }
    // DELETE api/quotes/id 
        [HttpDelete("{id}")] 
        public IActionResult Delete([FromBody] int id) 
        { 
            db.DeleteQuote(id);
            return Ok();
        }
}