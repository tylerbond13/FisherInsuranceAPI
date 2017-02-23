using System; 
namespace FisherInsuranceAPI.Models 
{ 
    public class Quote 
    { 
        public int Id { get; set; } 
        public string Product { get; set; } 
        public DateTime ExpireDate { get; set; } 
        public decimal Price { get; set; } 
    } 
     public class Claim
    { 
        public int Id { get; set; } 
        public string PolicyNumber { get; set; } 
        public DateTime LossDate { get; set; } 
        public decimal LossAmount { get; set; } 
        public string Status { get; set; }
    } 
}