using System;
using System.Collections.Generic;
using System.Text;
namespace Utility_Vehicle
{
    namespace Car
    {
        class Category
        {
            string category;
            public Category()
            {
                category = "Luxury Vehicle";
            }
            public void Display()
            {
                Console.WriteLine("Car Category: " + category);
            }
        }
    }
}