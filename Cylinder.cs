using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    internal class Cylinder
    {
        private double Radius;
        private double Height;
        private double baseArea;
        private double lateralArea;
        private double totalArea;
        private double volume;


        public void Process()
        {
            Console.WriteLine("Enter the dimenstions of the cylier: ");
            Console.WriteLine("Radius: ");
            Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height: ");
            Height = Convert.ToDouble(Console.ReadLine());

            baseArea = Radius * Radius * Math.PI;
            lateralArea = 2 * Math.PI * Radius *Height;
            totalArea = 2 * Math.PI* Radius * (Height + Radius);
            volume = Math.PI * Radius * Radius *Height;


        }
        public void Result()
        {
            Console.WriteLine("Base:" + baseArea);
            Console.WriteLine("Lateral: " + lateralArea);
            Console.WriteLine("Total: " + totalArea);
            Console.WriteLine("Voulume: " + volume);
        }

    }

}