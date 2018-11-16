using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public enum OutingType {Golf =1, Bowling, AmusementPark, Concert, Other}

    class Outings
    {
        public OutingType Event { get; set; }
        public int NumOfPeople { get; set; }
        public string Date { get; set; }
        public decimal PricePerson { get; set; }
        public decimal TotalCost { get; set; }

        public Outings(OutingType outing, int numOfPeople, string date, decimal perPerson, decimal totalCost) 
        {
            Event = outing;
            NumOfPeople = numOfPeople;
            Date = date;
            PricePerson = perPerson;
            TotalCost = totalCost;
        }
        public Outings()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
