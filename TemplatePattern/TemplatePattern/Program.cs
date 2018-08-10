using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHouse house = new PanelHouse();
            house.Build();
            Console.WriteLine("***************************");
            house = new BrickHouse();
            house.Build();
            Console.WriteLine("***************************");
            house = new PrivateHouse();
            house.Build();
            Console.WriteLine("***************************");

            Console.ReadLine();
        }
    }
}
