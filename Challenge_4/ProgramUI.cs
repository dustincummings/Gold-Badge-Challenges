using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    class ProgramUI
    {
        List<string> newDoorList = new List<string>();
        BadgeRepo _badgeRepo = new BadgeRepo();
        Dictionary<int, List<string>> newBadgeID = new Dictionary<int, List<string>>();
        Badge newBadge = new Badge();

        public void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("What action would you like to take:\n\t" +
                    "1. Create a new Badge\n\t" +
                    "2. Add door to Badge\n\t" +
                    "3. Remove all doors from Badge\n\t " +
                    "4. Show all created Badges" +
                    "5. Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1://Create a new Badge
                        CreateNewBadge();
                        break;
                    case 2://Add door to badge
                        AddDoorToBadge();
                        break;
                    case 3://Remove all doors from badge
                        RemoveAllDoors();
                        break;
                    case 4://Show all badges
                        ShowAllBadges();
                        break;
                    case 5://Exit
                        isRunning = false;
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option");
                        break;
                }

            }
        }
        public void CreateNewBadge()
        {
            Console.Clear();
            Console.WriteLine("Please enter ID number!");
            newBadge.BadgeNum = int.Parse(Console.ReadLine());
            bool addingDoor = true;
            while (addingDoor)
            {
                Console.WriteLine("Please enter in door you would like to give access to. (A1, B2, C3, etc..)");
                string door = Console.ReadLine();
                newDoorList.Add(door);
                Console.WriteLine("Are there more doors to add? y/n");
                string reponse = Console.ReadLine();
                if(reponse == "n")
                {
                    addingDoor = false;
                }
                _badgeRepo.AddBadge(newBadge);

            }


        }
        public void AddDoorToBadge()
        {

        }
        public void RemoveAllDoors()
        {

        }
        public void ShowAllBadges()
        {

        }
    }
}
