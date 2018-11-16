using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class OutingsRepo
    {
        List<Outings> _outingsList = new List<Outings>();

        public void AddOutingtoList(Outings outing)
        {
            _outingsList.Add(outing);
        }

        public List<Outings> ShowOutingList()
        {
            return _outingsList;
        }
        public decimal CalculateTotalCost()
        {
            decimal total=0;
            foreach(Outings o in _outingsList)
            {
                total += o.TotalCost;
            }
            return total;            
        }
        public decimal CalculateTotalCostByType(OutingType type)
        {
            decimal typeTotal = 0m;
            foreach(Outings t in _outingsList)
            {
                if (type == t.Event)
                {
                    typeTotal += t.TotalCost;
                }
            }
            return typeTotal;
        }

    }
}
