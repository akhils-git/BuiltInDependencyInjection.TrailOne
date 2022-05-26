// See https://aka.ms/new-console-template for more information
using InterfaceExample;

Console.WriteLine("Hello, World!");


IPlayerManage playerManage = new GameManage();
playerManage.Play();


Console.ReadKey();