using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoRepo
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public string Name { get; set; }
        public string ClaimType { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        public Claim(){}
        public Claim(int claimId, string name,string claimType, string description, double amount,DateTime dateOfIncident,DateTime dateOfClaim)
        {
            ClaimId = claimId;
            Name = name;
            ClaimType = claimType;
            Description = description;
            Amount = amount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
        }
    }
}
