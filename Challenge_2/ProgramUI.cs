using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    class ProgramUI
    {
        ClaimRepo claimRepo = new ClaimRepo();
        Queue<Claim> claimQueue = new Queue<Claim>();
        
        public void RunMenu()
        {
            Claim auto = new Claim(1, "Auto", "Broken window", 125.00m, "12/12/2012","12/20/2012", true);
            Claim home = new Claim(2, "Home", "Fire", 4000.00m, "11/15/2015", "12/25/2015", false);
            claimRepo.AddClaimToQueue(auto);
            claimRepo.AddClaimToQueue(home);
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("Choose a menu option:" +
                    "\n1. See all of the claims" +
                    "\n2. Take care of next claim" +
                    "\n3. Enter a new claim" +
                    "\n4. Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: //Show all claims using ToArray
                        ShowAllClaims();
                        break;
                    case 2: //Work next claim using Peek                        
                        WorkNextClaim();                        
                        break;
                    case 3: //Create new claim using Enqueue
                        NewClaim();
                        break;
                    case 4: //Exit
                        isRunning = false;
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please enter in a valid option!!");
                        break;
                }
            }
        }

        public void ShowAllClaims()
        {
            claimQueue = claimRepo.ShowClaimList();
            Console.Clear();

            Console.WriteLine("Claim ID# \t Type \t Description \t Claim Amount \t Date of Incident \t Date of Claim \t Is Valid");
            foreach(Claim claim in claimQueue)
            {
                Console.WriteLine($"{claim.ClaimID}\t {claim.Type}\t {claim.Description}\t {claim.ClaimAmount:c2}\t {claim.DateOfIncident}\t {claim.DateOfClaim}\t {claim.IsValid}");
            }
            Console.ReadLine();
        }

        public void NewClaim()
        {
            Claim claim = new Claim();
            Console.Clear();
            Console.WriteLine("What is the claim ID number for this claim?");
            claim.ClaimID = int.Parse(Console.ReadLine());

            Console.WriteLine("What type of claim is this?");
            claim.Type = Console.ReadLine();

            Console.WriteLine("Please give a breif description of the claim.");
            claim.Description = Console.ReadLine();

            Console.WriteLine("What is the dollar amount for this claim?");
            claim.ClaimAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("What was the date of the incident? mm/dd/yyyy");
            claim.DateOfIncident = Console.ReadLine();

            Console.WriteLine("What was the date that this incident was reported? mm/dd/yyyy");
            claim.DateOfClaim = Console.ReadLine();

            claim.IsValid = claimRepo.GetBoolan(claim);

            claimRepo.AddClaimToQueue(claim);
        }

        public void WorkNextClaim()
        {
            claimQueue = claimRepo.NextClaim();
            Console.Clear();
            Console.WriteLine("The next claim is:");
            Console.WriteLine($"{claimQueue.Peek()}");
                      
            Console.WriteLine("Would you like to handle this claim? (y/n)");
            string handleClaim = Console.ReadLine();
            if (handleClaim == "y")
            {
                claimRepo.RemoveClaim();
            }
        }
    }
}
