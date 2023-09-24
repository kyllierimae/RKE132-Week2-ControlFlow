// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada oma vanust
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
// "You are too young to use Instagram!"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram!"

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;


bool isAgeNUmber = Int32.TryParse(userAge, out userAgeNum);


Console.WriteLine($"Parse result {isAgeNUmber}. User is {userAgeNum}.");

if (isAgeNUmber)
{if (userAgeNum > 12)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram!");
    } 
}
else
{
    Console.WriteLine("Could not read your age.");
}
