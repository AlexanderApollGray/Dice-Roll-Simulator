// Dice Roll Simulator by Xander
Console.Clear();
#nullable disable

// Title
Console.WriteLine("Dice Roll Simulator Menu");

// Main Loop
while (true)
{

    // Dice Results
    Random rnd = new Random();

    // Menu
    Console.WriteLine("\n1. Roll Dice Once");
    Console.WriteLine("2. Roll Dice 5 Times");
    Console.WriteLine("3. Roll Dice 'n' Times");
    Console.WriteLine("4. Roll Dice Until Snake Eyes");
    Console.WriteLine("5. Exit");
    // Get Input from User
    Console.Write("Select an option (1-5): ");
    string option = Console.ReadLine();

    // Process Input
    if (option == "1")
    {
        int dice1 = rnd.Next(1, 7);
        int dice2 = rnd.Next(1, 7);
        int sum = dice1 + dice2;
        Console.WriteLine($"{dice1}, {dice2} (sum: {sum})");
    }
    else if (option == "2")
    {

        for (int n = 0; n < 5; n++)
        {
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int sum = dice1 + dice2;
            Console.WriteLine($"{dice1}, {dice2} (sum: {sum})");
        }
    }
    else if (option == "3")
    {
        Console.Write("\nHow many rolls would you like? ");
        int number = Convert.ToInt16(Console.ReadLine());
        for (int n = 0; n < number; n++)
        {
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int sum = dice1 + dice2;
            Console.WriteLine($"{dice1}, {dice2} (sum: {sum})");
        }
    }
    else if (option == "4")
    {
        int rollCount = 0;
        while (true)
        {
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int sum = dice1 + dice2;
            Console.WriteLine($"{dice1}, {dice2} (sum: {sum})");
            rollCount++;

            if (sum == 2)
            {
                Console.WriteLine($"Snake eyes! It took {rollCount} rolls to get snake eyes.");
                break;
            }
        }
    }
    else if (option == "5")
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid Entry");
    }
}