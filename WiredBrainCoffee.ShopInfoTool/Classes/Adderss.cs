using System;
using System.Collections.Generic;
using System.Text;

namespace WiredBrainCoffee.ShopInfoTool.Classes
{
    public class Adderss
    {
        public Adderss(string Address)
        {
            this.Address = Address;
        }
        public string Address { get; }

        public void AddressFunction()
        {
            Console.WriteLine($"Address = {Address}");
        }
    }
}
