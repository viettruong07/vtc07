using System;
using System.Collections.Generic;
using System.Text;
using Automotive.Vehicle.Jeep;
using Utility_Vehicle = Automotive.Vehicle.Jeep;
namespace Automotive
{
    namespace Vehicle
    {
        namespace Jeep
        {
            class Category
            {
                string category;
                public Category()
                {
                    category = "Multi Utility Vehicle";
                }
                public void Display()
                {
                    Console.WriteLine("Jeep Category: " + category);
                }
            }
        }
        class Automobile
        {
            static void Main(string[] args)
            {
                Category objCat = new Category();
                objCat.Display();
                Utility_Vehicle.Category objCategory = new Utility_Vehicle.Category();
                objCategory.Display();
            }
        }
    }
}