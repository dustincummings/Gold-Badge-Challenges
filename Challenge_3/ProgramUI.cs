using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class ProgramUI
    {
        OutingsRepo _outingsRepo = new OutingsRepo();
        Outings newOuting = new Outings();               

        public void RunMenu()
        {
            Outings disneyWorld = new Outings(OutingType.AmusementPark, 5, "06/15/2012", 100.00m, 500.00m);
            Outings shinedown = new Outings(OutingType.Concert, 10, "05/20/2015", 50.00m, 500.00m);
            Outings sixFlags = new Outings(OutingType.AmusementPark, 25, "02/06/2016", 100.00m, 2500.00m);
            _outingsRepo.AddOutingtoList(sixFlags);
            _outingsRepo.AddOutingtoList(disneyWorld);
            _outingsRepo.AddOutingtoList(shinedown);
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose a menu option:" +
                   "\n1. See All Outings List" +
                   "\n2. Add Outing to List" +
                   "\n3. See Cost for All Outings" +
                   "\n4. See Cost by Outing Type" +
                   "\n5. Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: //List all outings
                        ShowAllOutings();
                        break;
                    case 2: //Add outing to list
                        AddOuting();
                        break;
                    case 3: //See Total cost
                        Console.Clear();
                        Console.WriteLine($"The total cost is {_outingsRepo.CalculateTotalCost():c}");
                        Console.ReadLine();
                        break;
                    case 4: //See cost per type
                        CostByType();
                        break;
                    case 5: //Exit
                        isRunning = false;
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please enter in a valid option!!");
                        break;
                }
            }
        } 
        
        public void ShowAllOutings()
        {
            Console.Clear();
            List<Outings> outingsList = _outingsRepo.ShowOutingList();

            Console.WriteLine("Date\t EventType\t NumOfPeople\t PricePerPerson\t TotalCost");
            foreach(Outings outing in outingsList)
            {
                Console.WriteLine($"{outing.Date}\t{outing.Event}\t{outing.NumOfPeople}\t{outing.PricePerson:c}\t{outing.TotalCost:c}");
            }
            Console.ReadLine();
        }
        public void AddOuting()
        {
            Console.Clear();
            Console.WriteLine("What type of outing was this:\n\t" +
                "1. Golf\n\t" +
                "2. Bowling\n\t" +
                "3. Amusement Park\n\t" +
                "4. Concert\n\t" +
                "5. Other");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1://Golf
                    newOuting.Event = OutingType.Golf;
                    break;
                case 2: //Bowling
                    newOuting.Event = OutingType.Bowling;
                    break;
                case 3: //Amusement Park
                    newOuting.Event = OutingType.AmusementPark;
                    break;
                case 4: //Concert
                    newOuting.Event = OutingType.Concert;
                    break;
                case 5: //Other
                    newOuting.Event = OutingType.Other;
                    break;
                default:
                    Console.WriteLine("Choose a valid option!");
                    break;
            }
            Console.WriteLine("How many people attended this event?");
            newOuting.NumOfPeople = int.Parse(Console.ReadLine());
            Console.WriteLine("What was the date for this event? mm/dd/yyyy");
            newOuting.Date = Console.ReadLine();
            Console.WriteLine("What was the cost per person for this event?");
            newOuting.PricePerson = decimal.Parse(Console.ReadLine());

            newOuting.TotalCost = newOuting.PricePerson * newOuting.NumOfPeople;
            _outingsRepo.AddOutingtoList(newOuting);
        }
        
        public void CostByType()
        {
            Console.Clear();
            decimal totalByType = 0;
            Console.WriteLine("What type of outing would you like the total:\n\t" +
                "1. Golf\n\t" +
                "2. Bowling\n\t" +
                "3. Amusement Park\n\t" +
                "4. Concert\n\t" +
                "5. Other");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1://Golf
                    totalByType = _outingsRepo.CalculateTotalCostByType(OutingType.Golf);
                    break;
                case 2: //Bowling
                    totalByType = _outingsRepo.CalculateTotalCostByType(OutingType.Bowling);
                    break;
                case 3: //Amusement Park
                    totalByType = _outingsRepo.CalculateTotalCostByType(OutingType.AmusementPark);
                    break;
                case 4: //Concert
                    totalByType = _outingsRepo.CalculateTotalCostByType(OutingType.Concert);
                    break;
                case 5: //Other
                    totalByType = _outingsRepo.CalculateTotalCostByType(OutingType.Other);
                    break;
                default:
                    Console.WriteLine("Choose a valid option!");
                    break;
            }
            Console.WriteLine($"The total cost for this type of outing:{totalByType:c}");
            Console.ReadLine();
        }
    }
}
