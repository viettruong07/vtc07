using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LionAndTiger
{
    class Lion : Animal
    {
        public Lion(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public override void Show()
        {
            Console.WriteLine("Name: " + name + ", Weight: " + weight);
        }
    }
}