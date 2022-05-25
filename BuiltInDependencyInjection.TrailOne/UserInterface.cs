using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BuiltInDependencyInjection.TrailOne
{
    public class UserInterface : IUserInterface
    {
        public readonly IBusiness _business;
        public UserInterface(IBusiness userInterface)
        {
            _business = userInterface;
        }
        public void DataRead()
        {
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            _business.Login(username, password);
        }
    }
    public interface IUserInterface
    {
        public void DataRead();
    }


    public class Business : IBusiness
    {
        public readonly IFileDataStorage _fileStorage;
        public Business(IFileDataStorage fileStorage)
        {
            _fileStorage = fileStorage;
        }
        public void Login(string username, string password)
        {
            _fileStorage.Store(username, password);
        }

    }

    public interface IBusiness
    {
        public void Login(string username, string password);
    }


    public class FlatFileDataStorage : IFileDataStorage
    {

        public void Store(string username, string password)
        {
            //Move back to Project Dir and step up to "DataStorage"
            string filePath = System.IO.Path.GetFullPath(".\\..\\..\\..\\");

            // Data read from file
            string[] data = File.ReadAllLines(filePath + @"\DataStorage\FileStorage.txt");


            if (data[0] == username && data[1] == password)
            {
                Console.WriteLine("Login success.");
            }
            else
            {
                Console.WriteLine("Login Fail");
            }

        }
    }

    public interface IFileDataStorage
    {
        public void Store(string username, string password);
    }

    public class JsonFileDataStorage : IFileDataStorage
    {

        public void Store(string username, string password)
        {
            //Move back to Project Dir and step up to "DataStorage"
            string filePath = System.IO.Path.GetFullPath(".\\..\\..\\..\\");

            // Data read from file
            string fileJsonData = File.ReadAllText(filePath + @"\DataStorage\JsonStorage.json");


            User user = JsonSerializer.Deserialize<User>(fileJsonData);

            if (user.Username == username && user.Password == password)
            {
                Console.WriteLine("Login success.");
            }
            else
            {
                Console.WriteLine("Login Fail");
            }

        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
