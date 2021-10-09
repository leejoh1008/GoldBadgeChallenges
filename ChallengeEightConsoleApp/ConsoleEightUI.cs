using ChallengeEightRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeEightConsoleApp
{
    public class ConsoleEightUI
    {
        private Insurance _insurance = new Insurance();
        private InsuranceMethods _methods = new InsuranceMethods();
        private int five = 5;
        private int ten = 10;
        private int two = 2;
        public void Run()
        {
            Help(); 
            Menu();
        }
        public void Menu()
        {
            bool isRunning = true;
            while (isRunning == true)
            {
                Console.Clear();
                Console.WriteLine("MONTHLY KOMODO CAR INSURANCE CALCULATIONS!\nWELCOME\n What would you like to do?\n" +
                    "\n 1:Add a new person to the list." +
                    "\n 2:View the List\n" +
                    " 3:Leave the program.");
                string userResponse = Console.ReadLine();
                switch (userResponse)
                {
                    case "1":
                        AddPeep();
                        break;
                    case "2":
                      ListOfPeeps();
                        break;
                    case "3":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Thats not an option.");
                        break;
                }
             }
        }
        private void Help()
        {
            Insurance amy = new Insurance("Amy Blanc", 12, 10, 3, 1);
            _methods.AddInsurance(amy);
        }
        public void ListOfPeeps()
        {
            List<Insurance> people = _methods.GetList();
            foreach (Insurance insurance in people)
            {
                Console.WriteLine($"ID Number:{insurance.PersonId}\n" +
                    $"Name: {insurance.Name}\n" +
                    $"Times over speed limit: x{insurance.TimesOverSpeed} X $2 = ${insurance.TimesOverSpeed * two}\n" +
                    $"Times running a stop sign: x{insurance.TimesRanStopSign} X $5 = ${insurance.TimesRanStopSign * five}\n" +
                    $"Times running a red light: x{insurance.TimesRanStopLight} X $10 = ${insurance.TimesRanStopLight * ten}");
                int total = insurance.TimesOverSpeed * two + insurance.TimesRanStopSign * five + insurance.TimesRanStopLight * ten;
                Console.WriteLine($"\t\tMONTHLY COST TOTAL: ${total}\n\n_____________________________________________________________________________________________________");
            }
            Console.ReadLine();

        }
        public void AddPeep()
        {
            Console.Clear();
            Insurance peep = new Insurance();
            Console.WriteLine("Please enter a name");
            peep.Name = Console.ReadLine();
            Console.WriteLine("Enter a ID Numberr:");
            peep.PersonId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many times they've gone over the speed limit");
            peep.TimesOverSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many times they've drove through a stop sign");
            peep.TimesRanStopSign = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many times they've drove through a rerd light");
            peep.TimesRanStopLight = int.Parse(Console.ReadLine());
            _methods.AddInsurance(peep);
            Console.ReadLine();
        }
    }
}
