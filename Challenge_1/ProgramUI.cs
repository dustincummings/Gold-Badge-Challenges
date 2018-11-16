using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class ProgramUI
    {
        MenuRepo _menuRepo = new MenuRepo();
        public void Run()
        {

            Menu hamburger = new Menu(1, "Hamburger", "1/4 pound hamburger on a bun", "hamburger, bun", 4.0m);
            Menu chickenSandwhich = new Menu(2, "Chicken Sandwhich", "Crispy chicken breast on a bun", "chicken breast, bun", 7.00m);

            _menuRepo.AddItemToMenu(hamburger);
            _menuRepo.AddItemToMenu(chickenSandwhich);

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose an action:" +
                "\n\t1. Create new Menu Item" +
                "\n\t2. List entire Menu" +
                "\n\t3. Remove Menu Item" +
                "\n\t4. Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:  //Create New Item
                        CreateItem();
                        break;
                    case 2:  //Remove Item
                        PrintMenu();
                        break;
                    case 3:  //List of Items
                        RemoveItem();
                        break;
                    case 4:  //Exit
                        isRunning = false;
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option!!");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void CreateItem()
        {
            Menu newMenuItem = new Menu();

            Console.WriteLine("What is this menu item number?");
            newMenuItem.MealNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat is the menu item name?");
            newMenuItem.MealName = Console.ReadLine();

            Console.WriteLine("\nWrite a brief description of the menu item.");
            newMenuItem.Description = Console.ReadLine();

            Console.WriteLine("\nEnter in all of the ingredients of the meal.");
            newMenuItem.Ingredients = Console.ReadLine();

            Console.WriteLine("\nHow much would you like to charge for this menu item?");
            newMenuItem.MealPrice = decimal.Parse(Console.ReadLine());

            _menuRepo.AddItemToMenu(newMenuItem);
        }

        private void PrintMenu()
        {
            List<Menu> menuList = _menuRepo.GetMenuList();

            foreach (Menu item in menuList)
            {
                Console.WriteLine($"{item.MealNumber}\t {item.MealName}\t {item.Description}\t{item.Ingredients}\t{item.MealPrice:C}");
            }

            Console.ReadLine();
        }
        private void RemoveItem()
        {

            List<Menu> itemList = _menuRepo.GetMenuList();

            Console.WriteLine("\nPlease type in the menu item, using the meal name, that you would like removed.");
            foreach (Menu item in itemList)
            {
                Console.WriteLine($"{item.MealNumber}\t {item.MealName}\t {item.Description}\t{item.Ingredients}\t{item.MealPrice:C:}");

            }
            var removedItem = Console.ReadLine();
            foreach (Menu item in itemList)
            {
                if (removedItem == item.MealName)
                {
                    _menuRepo.RemoveItemFromMenu(item);
                    break;
                }
            }

        }
    }
}
