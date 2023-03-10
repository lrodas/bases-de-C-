// See https://aka.ms/new-console-template for more information

/*
 * 1. Validar si es usuario existente o si se debe registrar
 * 2. El programa debe ser capaz de darle la bienvenida a un usuario existente si en efecto exite
 * 2. El programa debe repetirse hasta que se registren las 10 personas
 */

string[] userNames = new string[10] { "Luis", "Pedro", "Joan", "Selena", "Mike", "Dani", "Brian", "Celis", "Jonas", "", };

int arrayCurrentIndex = 8;
bool userType=false;

Console.WriteLine("Welcome to the best restaurant in the work!");

while (arrayCurrentIndex < 10)
{
    Console.WriteLine("\n \n Are you a register user? Write true, or write false to register");
    userType = bool.Parse(Console.ReadLine());
    if (userType)
    {
        Console.WriteLine("Hello, you are a registered user, please enter your user name");
        string userNameToSearch = Console.ReadLine();
        Console.WriteLine("The user you searched is {0}", userNameToSearch);
        int index = Array.IndexOf(userNames, userNameToSearch);
        if (index == -1)
        {
            Console.WriteLine("User not doun, try again or register");
        } else
        {
            Console.WriteLine("Welcome {0}, it's a pleasure to give you food", userNames[index]);
        }
    }
    else
    {
        Console.WriteLine("Please write and remember your User Name");
        userNames[arrayCurrentIndex] = Console.ReadLine();
        Console.WriteLine("Your user has been saved succesfully\nYour user name is = {0}", userNames[arrayCurrentIndex]);
        arrayCurrentIndex++;

    }
}

Console.WriteLine("The restaurant is full, try again next year");
int auxIndex = 0;
foreach(string userName in userNames)
{
    Console.WriteLine("User number {0} and user name: {1}", auxIndex+1, userNames[auxIndex]);
    auxIndex++;
}
Environment.Exit(0);