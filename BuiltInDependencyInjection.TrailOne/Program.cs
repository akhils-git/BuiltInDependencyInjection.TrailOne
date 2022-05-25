// See https://aka.ms/new-console-template for more information
using BuiltInDependencyInjection.TrailOne;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("User Login");


while (1==1)
{
    #region DependencyInjection
    //IFileDataStorage fileDataStorage = new JsonFileDataStorage();
    ////IFileDataStorage fileDataStorage = new FlatFileDataStorage();
    //IBusiness business = new Business(fileDataStorage);
    //IUserInterface userInterface = new UserInterface(business);
    //userInterface.DataRead();
    #endregion

    #region BuiltDependencyInjection
    var collection = new ServiceCollection();
    collection.AddScoped<IFileDataStorage, FlatFileDataStorage>();
    //collection.AddScoped<IFileDataStorage, JsonFileDataStorage>();
    collection.AddScoped<IBusiness, Business>();

    var provider = collection.BuildServiceProvider();

    IBusiness business = provider.GetService<IBusiness>();
    var userInterface = new UserInterface(business);
    userInterface.DataRead();
    #endregion

    Console.ReadKey();
    Console.Clear();
}




