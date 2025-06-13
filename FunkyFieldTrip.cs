using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

internal class FunkyFieldTrip
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Please tell me your age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose a camp! (Type 1 - 3 to select)");
        Console.WriteLine("1 - Cultural immersion (Days: 5 Difficulty: Easy Cost: $800)");
        Console.WriteLine("2 - Kayaking and pancakes (Days: 3 Difficulty: Moderate Cost: $400)");
        Console.WriteLine("3 - Mountain biking (Days: 4 Difficulty: Difficult Cost: $900)");

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
        Console.Write("Do you want to take the shuttle bus? (yes/no): ");

        string goingonshuttle = "";
        int shuttlecost = 0;

        Console.WriteLine("Do you want to use the shuttle bus for $80? (yes or no)");
        string shuttlestatus = Console.ReadLine().ToLower();

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

        Console.Write("Choose a meal type (Standard/Vegetarian/Vegan): ");
        string mealChoice = Console.ReadLine().ToLower();

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

        Console.WriteLine($"{totalCost}");
    }
}



