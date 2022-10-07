// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using SwitchAndEnums;

Console.WriteLine();

Car car;
car = new Car();
car.PrintInfo();

Car c1 = new Car("Mercedes", 200);
c1.PrintInfo();

Car c2 = new Car("Nissan", 180);
c2.PrintInfo();
c2.IncreaseSpeed(50);
c2.PrintInfo();

Console.WriteLine();

// int x = int.Parse(Console.ReadLine()!);
// int y;
//
// switch (x)
// {
//     case 10:
//     case 11:
//         y = x * 11;
//         x = 15;
//         break;
//     case 12:
//         Console.WriteLine("x is 12");
//         break;
//     case 15:
//         Console.WriteLine("x is 15");
//         break;
//     case 3:
//         Console.WriteLine("x is 3");
//         break;
//     default:
//         Console.WriteLine("None");
//         break;
// }