using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoRepo
{
    public class ClaimMethods
    {
        private List<Claim> _claims = new List<Claim>();
        
        public bool AddClaim(Claim claim)    //create
        {
            if(claim is null)
            {
                return false;
            }
            
            _claims.Add(claim);
            return true;
        }
        public bool DeleteClaim(Claim claim) //delete
        {
            if (claim is null)
            {
                return false;
            }
            _claims.Remove(claim);
            return true;
        }
        public List<Claim> GetList()
        {

            return _claims;
        }

        public Claim GetClaimById(int id)
        {
            foreach (Claim claim in _claims)
            {
                if (claim.ClaimId == id)
                {
                    return claim;
                }
            }
            return null;
        }
       
        public Claim FirstItem()
        {   Claim firstClaim = _claims.First();
            return firstClaim;
        }

    }
}
