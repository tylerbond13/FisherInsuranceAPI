using Microsoft.AspNetCore.Mvc;
using FisherInsuranceAPI.Data;
using FisherInsuranceAPI.Models;


[Route("api/claims")] 
public class ClaimsController : Controller 
{ 
        private readonly FisherContext db;
    public ClaimsController (FisherContext context)
        {
        db = context;
        }

        // GET api/claims
        [HttpGet]
        public IActionResult GetClaims()
        { 
        return Ok(db.Claims);
    }
    
    // GET api/claims/id
    [HttpGet("{id}", Name = "GetClaims")]
    public IActionResult Get(int id)
    {
        return Ok(db.Claims.Find(id));
    }

    // POST api/claims
    [HttpPost]
    public IActionResult Post([FromBody]Claim claim)
    {
        var newClaim = db.Claims.Add(claim);
        db.SaveChanges();

        return CreatedAtRoute("GetClaim", new {id = claim.Id}, claim); 
    }

    // PUT api/claims/id
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody]Claim claim)
    {
        var newClaim = db.Claims.Find(id);
        if (newClaim == null)
        {
            return NotFound();
        }
        newClaim = claim;

        db.SaveChanges();
        return Ok(newClaim);
    }

    // DELETE api/claims/id
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var claimToDelete = db.Claims.Find(id);
        if (claimToDelete == null)
        {
            return NotFound();
        }
        db.Claims.Remove(claimToDelete);
        db.SaveChangesAsync();
        return NoContent();
    }
}