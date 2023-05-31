using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Animal;

namespace LionAndTiger
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion = new Lion(200, "lion");
            Tiger tiger = new Tiger(100, "tiger");

            lion.Show();
            tiger.Show();
        }
    }

}