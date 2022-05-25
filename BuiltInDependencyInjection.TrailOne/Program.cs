// See https://aka.ms/new-console-template for more information
using BuiltInDependencyInjection.TrailOne;

Console.WriteLine("User Login");

IFileDataStorage fileDataStorage = new FileDataStorage();
IBusiness business = new Business(fileDataStorage);
UserInterface  userInterface = new UserInterface(business);
userInterface.DataRead();
Console.ReadKey();


