using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class ClaimRepo
    {
        Queue<Claim> _queueOfClaim = new Queue<Claim>();
        bool _isValid;

        public void AddClaimToQueue(Claim claim)
        {
            _queueOfClaim.Enqueue(claim);
        }

        public Queue<Claim> ShowClaimList()
        {
            return _queueOfClaim;
        }

        public Queue<Claim> RemoveClaim()
        {
            
            _queueOfClaim.Dequeue();
            return _queueOfClaim;
        }

        public Queue<Claim> NextClaim()
        {
            return _queueOfClaim;
        }
        public bool GetBoolan(Claim claim)
        {
            TimeSpan TimeBetweenDates = Convert.ToDateTime(claim.DateOfClaim) - Convert.ToDateTime(claim.DateOfIncident);

            bool IsVaild;
            if(TimeBetweenDates.Days <= 30)
            {
                _isValid = true;
            }
            else
            {
                _isValid = false;
            }

            IsVaild = _isValid;
            return IsVaild;
        }
    }
}
