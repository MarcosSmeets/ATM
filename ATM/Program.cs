using ATM;

static void main(string[] args)
{
    void printOptions()
    {
        Console.WriteLine("Please choose from one of the following options...");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Show Balance");
        Console.WriteLine("4. Exit");
    }

    void deposit(cardHolder currentUser)
    {
        Console.WriteLine("How much $$ would you like to deposit? ");
        try
        {
            double deposit = double.Parse(Console.ReadLine());
            currentUser.Balance += deposit;
        }
        catch(Exception e)
        {
            throw e;
        }
        Console.WriteLine("Thank you. Your new balance is: " + currentUser.Balance);       
    }

    void withdraw(cardHolder currentUser)
    {
        Console.WriteLine("How much $$ would you like to withdraw: ");
        try
        {
            double withdraw = double.Parse(Console.ReadLine());
            if(currentUser.Balance < withdraw)
            {
                Console.WriteLine("Insufficient $$ :(");
            }
            else
            {
                currentUser.Balance -= withdraw;
                Console.WriteLine("You're good to go! Thank you :)");
            }
        }catch(Exception e)
        {
            throw e;
        }
    }

    void balance(cardHolder currentUser)
    {
        Console.WriteLine("Current balance: " + currentUser.Balance);
    }

    List<cardHolder> cardHolders = new List<cardHolder>();
    cardHolders.Add(new cardHolder("453118365138871", 1234, "Marcos", "Smeets", 150.2));
    cardHolders.Add(new cardHolder("638634358314433", 4652, "John", "Griffith", 1000.89));
    cardHolders.Add(new cardHolder("783214538713541", 9874, "Frida", "Dickerson", 105.59));
    cardHolders.Add(new cardHolder("342156583135454", 6549, "Dawn", "Smith", 54.27));

    Console.WriteLine("Welcome to ATM");
    Console.WriteLine("Please insert you debit card: ");
    string debitCardNum = "";
    cardHolder currentUser;

    while (true)
    {
        try
        {
            debitCardNum = Console.ReadLine();
            currentUser = cardHolders.FirstOrDefault(x => x.CardNum == debitCardNum);
            if (currentUser != null)
                break;
            else
                Console.WriteLine("Card not recognized. Please try again");
        }
        catch(Exception e)
        {
            Console.WriteLine("Card not recognized. Please try again");
            throw e;
        }
    }

    Console.WriteLine("Please enter yor pin: ");
    int userPin = 0;
    while (true)
    {
        try
        {
            userPin = int.Parse(Console.ReadLine());
            if (currentUser.Pin == userPin)
                break;
            else
                Console.WriteLine("Incorrect pin. Please try again");
        }
        catch(Exception e)
        {
            throw e;
        }
    }

    Console.WriteLine("Welcome " + currentUser.FirstName + " :)");
    int option = 0;
    do
    {
        printOptions();
        try
        {
            option = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            throw e;
        }
        if (option == 1)
            deposit(currentUser);
        else if (option == 2)
            withdraw(currentUser);
        else if (option == 3)
            balance(currentUser);
        else if (option == 4)
            break;
        else
            option = 0;
    }
    while (option != 0);
    Console.WriteLine("Thank you!");

}