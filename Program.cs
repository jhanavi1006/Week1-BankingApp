void BuildBankingApp()
{
    int choice;
    double depositAmount;
    double accountBalance = 1000.00;

    Console.WriteLine("Please choose an option");
    Console.WriteLine("=======================");
    Console.WriteLine("1 - Deposit or withdraw funds");
    Console.WriteLine("2 - View current account information");
    Console.WriteLine("Please choose an option (1-2)");

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        Console.WriteLine("You have chosen to deposit or withdraw funds");
        Console.WriteLine("How much do you want to deposit?");
        Console.WriteLine("Enter amount including pence using a decimal point");

        depositAmount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Your original account balance was {accountBalance}");

        accountBalance += depositAmount;

        Console.WriteLine($"Your new account balance is {accountBalance}");
    }
    else if (choice == 2)
    {
        Console.WriteLine("You have chosen to view current account information");
        Console.WriteLine($"Your current account balance is {accountBalance}");
    }
    else
    {
        Console.WriteLine("Invalid choice, please choose 1 or 2");
    }
}

BuildBankingApp();