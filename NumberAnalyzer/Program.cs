// my first lab!

Console.WriteLine("Welcome to the Number Analyzer!");
Console.WriteLine();
Console.WriteLine("Together we can analyze some numbers. What is your name?");
string userName = Console.ReadLine();



bool goAgain = true;

while (goAgain == true)
{

    Console.WriteLine("Please enter an integer between 1 and 100");
    string userInput = Console.ReadLine();
    int usersNumber = int.Parse(userInput);

    if (usersNumber % 2 != 0 && usersNumber < 60)
    {
        Console.WriteLine("That number is odd and less than 60.");
    }
    else if (usersNumber % 2 == 0 && usersNumber <= 2 && usersNumber <= 24)
    {
        Console.WriteLine("That number is even and it is less than 25.");
    }
    else if (usersNumber % 2 == 0 && usersNumber >= 26 && usersNumber <= 60)
    {
        Console.WriteLine("That number is even and between 26 and 60 inclusive.");
    }
    else if (usersNumber % 2 == 0 && usersNumber > 60)
    {
        Console.WriteLine("That number is even and greater than 60.");
    }
    else if (usersNumber % 2 != 0 && usersNumber > 60)
    {
        Console.WriteLine("That number is odd and greater than 60.");
    }
    



    bool y = true;

    do
    {
        Console.WriteLine("Would you like to enter another number? Please enter yes or no");
        string userToContinue = Console.ReadLine().ToLower();
        Console.WriteLine();

        if (userToContinue == "yes")
        {
            goAgain = true;
            y = false;
        }
        else if (userToContinue != "yes" && userToContinue != "no")
        {
            Console.WriteLine("Hi " + userName + " please enter either yes or no!");
            y = true;
        }
        else if (userToContinue == "no")
        {
            goAgain = false;
            Console.WriteLine("Thank you for playing, see you next time!");
            break;
        }

    } while (y == true);

}



// still trying to figure out the last bonus point of adding validation to guarantee that a user enters a positive integer between 1 and 100.

