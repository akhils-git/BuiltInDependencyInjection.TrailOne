using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithOutDependencyInjection
{
    public class UserInterface
    {
        public void DataRead()
        {
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            Business business = new Business();
            business.Login(username, password);
        }
    }
    public class Business
    {
        public void Login(string username, string password)
        {
            FlatFileDataStorag flatFileDataStorag = new FlatFileDataStorag();
            flatFileDataStorag.Store(username, password);
        }
    }

    public class FlatFileDataStorag
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
}
