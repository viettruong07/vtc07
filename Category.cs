using System;
namespace Automotive
{
    public class Category
    {
        string category;
        public Category()
        {
            category = "Multi Utility Vehicle";
        }
        public void Display()
        {
            Console.WriteLine("Category: " + category);
        }
    }
}