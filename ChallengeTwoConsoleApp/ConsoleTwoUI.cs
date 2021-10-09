using ChallengeTwoRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwoConsoleApp
{
    class ConsoleTwoUI
    {
        private Claim _claims = new Claim();
        private ClaimMethods _methods = new ClaimMethods();
        public void Run() 
        {
            ListOfClaims();
            Menu();
        }
        public void Menu()
        {
            bool isRunning = true;
            while (isRunning == true)
            {
                Console.Clear();
                Console.WriteLine("KOMODO INSURANCE CLAIM AGENT!\nWELCOME\n What would you like to do?\n 1:See all claims" +
                    "\n 2:Take care of the next Claim." +
                    "\n 3:Enter a new Claim.\n" +
                    "4:Leave the program.");
                string userResponse = Console.ReadLine();
                switch (userResponse)
                {
                    case "1":
                        ReadList();
                        break;
                    case "2":
                        SubmitClaim();
                        break;
                    case "3":
                        NewClaim();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Thats not an option.");
                        break;
                }
            }
        }
        private void ListOfClaims()
        {
            string one = "1/23/2001";
            DateTime two = DateTime.Parse(one);
            Claim john = new Claim(12, "Johnson Lee", "Home", "Broken Window",123.33, two,two);
            _methods.AddClaim(john);
            string second = "5/15/2019";
            DateTime seven = DateTime.Parse(second);
            Claim aria = new Claim(12, "Aria Beck", "car", "Broken Engine", 400.99, seven, seven);
            _methods.AddClaim(aria);


        }
        private void ReadList()
        {
            Console.WriteLine("ClaimID:\t Name:\t Type:\t Description\t Amount\t DateOfAccident\t DateOfClaim\t isValid\n");
            List<Claim> listOfClaims = _methods.GetList();                    
            foreach(Claim claim in listOfClaims)
            {
                Console.WriteLine( $"{claim.ClaimId}\t {claim.Name}\t {claim.ClaimType}\t {claim.Description}\t {claim.Amount}\t {claim.DateOfIncident}\t {claim.DateOfClaim}\t {claim.IsValid}");
            }
            
            Console.ReadLine();
        }
        private void SubmitClaim()
        {
            /*Console.WriteLine("What Claim would you like to address? Specify by ID");
            int id = int.Parse(Console.ReadLine());
            Claim claim = _methods.GetClaimById(id);
            bool wasDelete = _methods.ClaimCleared(id);
            if (wasDelete)
            {
                Console.WriteLine($"Claim {claim.ClaimId} was successfully cleared!.");
            }
            else
            {
                Console.WriteLine("Something went wrong! Please try again");
            }*/
            Console.Clear();
            Claim first = _methods.FirstItem();
            Console.WriteLine($"ClaimID: {first.ClaimId}\n " +
                $"Type: {first.ClaimType}\n" +
                $"Name: {first.Name}\n" +
                $"Description: {first.Description}\n" +
                $"Cost: {first.Amount}\n" +
                $"DateOfAccident: {first.DateOfIncident}\n" +
                $"DateOfClaim: {first.DateOfClaim}\n " +
                $"IsValid: {first.IsValid}\n " +
                $"\tDO YOU WANT TO DEAL WITH THIS CLAIM NOW? yes or no");
            string input = Console.ReadLine().ToLower();
           if(input == "yes" || input =="no")
            {
                if(input == "yes")
                {
                    Console.WriteLine("THANK YOU FOR YOUR HARD WORK.");
                    _methods.DeleteClaim(first);
                    Menu();
                }
                if (input == "no")
                { Menu(); }
            }
           else 
            {
                Console.WriteLine("Try again."); 
                Menu(); 
            }
        }
        private void NewClaim()
        {
            Console.Clear();
            Claim claim = new Claim();
            Console.WriteLine("Please enter their FULL name:");
            claim.Name = Console.ReadLine();
            Console.WriteLine("Please enter if the claim is a home, theft, or car type:");
            string type = Console.ReadLine().ToLower();
            if (type == "car" || type == "home" || type == "theft")
            {
                claim.ClaimType = type;

            }
            else 
            { 
                Console.WriteLine("Please try again.");
                NewClaim();
            }
            Console.WriteLine("Enter a brief description");
            claim.Description = Console.ReadLine();
            Console.WriteLine("Enter a Claim Id number");
            claim.ClaimId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the damage cost in a xxx.00 format");
            double cost = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the date when the accident happened in x/xx/xxxx format:");
            DateTime dateOfevent = DateTime.Parse(Console.ReadLine());
            claim.DateOfIncident = dateOfevent;
            Console.WriteLine("Enter the date when the claim was made in x/xx/xxxx format:");
            DateTime dateOfClaim = DateTime.Parse(Console.ReadLine());
            claim.DateOfClaim = dateOfClaim;
            Console.WriteLine("Is the claim still valid? yes or no");
            string input = Console.ReadLine().ToLower();
            if(input == "yes" || input == "no")
            { if (input == "yes")
                {
                    claim.IsValid = true;
                }
                else if(input == "no")
                { claim.IsValid = false; }
            }
            else
            {
                Console.WriteLine("Please try again.");
                NewClaim();
            }
            _methods.AddClaim(claim);
            Menu();

        }
    }
}
