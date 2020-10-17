using System;
using System.ComponentModel.DataAnnotations;
using WiredBrainCoffee.ShopInfoTool.Classes;

namespace WiredBrainCoffee.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wired Brain Coffee - Shop Info Tool!");
            Console.WriteLine("Hello Anis");
            Console.WriteLine("Hello Anik");

            Console.WriteLine(110);
            Console.WriteLine(200);
            Console.WriteLine(100);
            Console.WriteLine(300);
            Display();
            Display1();

            Person p = new Person(10, "Anis");
            p.PersonDetails();

            Adderss a = new Adderss("Uttara 10");
            a.AddressFunction();

        }

        static public void Display()
        {
            Console.WriteLine("Function Called");
        }

        static public void Display1()
        {
            Console.WriteLine();
        }
    }
}
