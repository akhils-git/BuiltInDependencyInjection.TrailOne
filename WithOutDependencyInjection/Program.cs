// See https://aka.ms/new-console-template for more information
using WithOutDependencyInjection;



Console.WriteLine("WithOut Dependency Injection Trail Program");
Console.WriteLine("User login");


while (1 == 1)
{
    UserInterface userInterface = new UserInterface();
    userInterface.DataRead();
    Console.ReadKey();
    Console.Clear();
}