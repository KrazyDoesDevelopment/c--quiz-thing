using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

internal class FunkyFieldTrip
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        int age;
        Console.WriteLine("Please tell me your age:");
        //Checks if the answer is numeric and loops if its not. (Kinda stole half of it. Dont judge me :P)
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("That's not a valid number. Please enter your age as a number:");
        }
        //Selection Panel

        string[] campoptions = { "1 - Cultural immersion (Days: 5 Difficulty: Easy Cost: $800)", "2 - Kayaking and pancakes (Days: 3 Difficulty: Moderate Cost: $400", "3 - Mountain biking (Days: 4 Difficulty: Difficult Cost: $900)" };

        Console.WriteLine("Choose a camp! (Type 1 - 3 to select)");
        Console.WriteLine(campoptions[0]);
        Console.WriteLine(campoptions[1]);
        Console.WriteLine(campoptions[2]);

        //Variable Stuff
        int campChoice = int.Parse(Console.ReadLine());
        string campName = "";
        int campDays = 0;
        string difficulty = "";
        int campCost = 0;

        if (campChoice == 1)
        {
            campName = "Cultural immersion";
            campDays = 5;
            difficulty = "easy";
            campCost = 800;
        }
        else if (campChoice == 2)
        {
            campName = "Kayaking and pancakes";
            campDays = 3;
            difficulty = "moderate";
            campCost = 400;
        }
        else if (campChoice == 3)
        {
            campName = "Mountain biking";
            campDays = 4;
            difficulty = "difficult";
            campCost = 900;
        }
        
        string goingonshuttle = "";
        int shuttlecost = 0;

        string shuttlestatus = Console.ReadLine().ToLower();
        Console.WriteLine("Do you want to use the shuttle bus for $80? (yes or no)");
       
       
        if (shuttlestatus == "yes")
        {
            goingonshuttle = "yes";
            shuttlecost = 80;
        }
        else if (shuttlestatus == "no")
        {
            goingonshuttle = "no";
        }

        int totalCost = campCost + shuttlecost;

        string mealChoice = Console.ReadLine().ToLower();
        Console.Write("Choose a meal type (Standard/Vegetarian/Vegan): ");
        if (age >= 15)
        {
            string leaderchoice = Console.ReadLine().ToLower();
            Console.WriteLine("You are eligible for a leadership role. Do you accept? (Yes/No)");

            if (leaderchoice == "yes")
            {
                Console.Write("You are now a leader.");
            }
            else if (leaderchoice == "no")
            {
                Console.Write("You have decided to not be a leader.");
            }
        }

        Console.WriteLine($"You have decided to go to the {campChoice} camp for {totalCost}");
    }
}


