using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiltInDependencyInjection.TrailOne
{
    public class UserInterface
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
  

    public class Business: IBusiness
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


    public class FileDataStorage: IFileDataStorage
    {
        public void Store(string username, string password)
        {
          string[] data = File.ReadAllLines(@"C:\Data\FileStorage.txt");
            if (data[0]== username && data[1]== password)
            {
                Console.WriteLine("User login done");
            }
            else
            {
                Console.WriteLine("Fail");
            }
          
        }
    }

    public interface IFileDataStorage
    {
        public void Store(string username, string password);
    }
}
