
using ChallengeOneRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOneRepo
{
    class ConsoleOneUI
    {
        private MenuItems _menuItems = new MenuItems();
        private MenuMethods _menuMethods = new MenuMethods();
        public void Run()
        {
            SmallMenu();
            Menu();
        }
        private void Menu()
        {
            bool isRunning = true;
            while(isRunning == true)
            {
                Console.Clear();
                Console.WriteLine("Komodo cafe\n Welcome Manager, what would you like to do to the menu?\n" +
                    "1.Make a menu item\n" +
                    "2.Delete a menu item\n" +
                    "3.Look at the menu\n" +
                    "4. Leave Program");

                string userResponse = Console.ReadLine();
                switch (userResponse)
                {
                    case "1":
                        Console.Clear();
                        AddItem();
                        
                        break;
                    case "2":
                        Console.Clear();
                        DeleteItem();
                        break;
                    case "3":
                        Console.Clear();
                        ShowMenu();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }
        private void AddItem()                  //adding a menu item
        {
            Console.Clear();
            MenuItems item = new MenuItems();
            Console.WriteLine("Please enter what number the menu item shall have:");
            item.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the name  of the new menu item:");
            item.Name = Console.ReadLine();
            Console.WriteLine("Please enter a short description:");
            item.Description = Console.ReadLine();
            Console.WriteLine("Please enter a list of ingredients:");
            item.Ingredients = Console.ReadLine();
            Console.WriteLine("Please enter a price for the new menu item: EX= 9.99");
            item.Price = double.Parse(Console.ReadLine());
            _menuMethods.AddMenu(item);
        }
        private void DeleteItem()           //deleting a menu item
        {
            Console.Clear();
            Console.WriteLine("Please enter the ID number corresponding to the menu item that you would like to delete:");
            int input = int.Parse(Console.ReadLine());
            bool wasDeleted = _menuMethods.RemoveItemById(input);
            if (wasDeleted)
            {
                Console.WriteLine("The Menu Item was successfully Deleted.");
            }
            else
            {
                Console.WriteLine("There seems to be an error :/");

            }
            Console.ReadLine();
        }
        private void SmallMenu()            //helper method
        {
            MenuItems numone = new MenuItems(1, "SloppyJoe", 5.99, "a sloppy joe", "Sloppy Joe");
            _menuMethods.AddMenu(numone);
        }
        private void ShowMenu()
        {
            
            List<MenuItems> menu = _menuMethods.GetMenu();
            foreach(MenuItems item in menu)
            {
                Console.WriteLine($"#{item.Id} {item.Name} |${item.Price}|\n" +
                    $"Description: {item.Description}\n" +
                    $"Ingredients: {item.Ingredients}\n");

            }
            Console.ReadLine();
        }
    }
}
