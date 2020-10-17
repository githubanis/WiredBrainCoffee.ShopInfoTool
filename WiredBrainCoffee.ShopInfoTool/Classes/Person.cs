using System;
using System.Collections.Generic;
using System.Text;

namespace WiredBrainCoffee.ShopInfoTool.Classes
{
    public class Person
    {
        public Person(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public int Id { get; }
        public string Name { get; }



        public void PersonDetails()
        {
            Console.WriteLine($"Id = {Id} and Name = {Name}");
        }

    }
}
