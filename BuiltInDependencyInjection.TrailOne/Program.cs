using BuiltInDependencyInjection.TrailOne;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("User Login");

// loop help repeat menu
while (1==1)
{
    #region DependencyInjection
    //IDataStorage fileDataStorage = new JsonFileDataStorage();
    ////IFileDataStorage fileDataStorage = new FlatFileDataStorage();
    //IBusiness business = new Business(fileDataStorage);
    //IUserInterface userInterface = new UserInterface(business);
    //userInterface.DataRead();
    #endregion

    #region BuiltDependencyInjection
    var collection = new ServiceCollection();
    collection.AddScoped<IDataStorage, FlatFileDataStorage>();
    //collection.AddScoped<IFileDataStorage, JsonFileDataStorage>();
    collection.AddScoped<IBusiness, Business>();
    var provider = collection.BuildServiceProvider();

    IBusiness business = provider.GetService<IBusiness>()!;
    var userInterface = new UserInterface(business);
    userInterface.DataRead();
    #endregion

    Console.ReadKey();
    Console.Clear();
}




