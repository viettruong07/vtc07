﻿using System;
namespace Automotive
{
    public class SpareParts
    {
        string spareName;
        public SpareParts()
        {
            spareName = "Gear Box";
        }
        public void Display()
        {
            Console.WriteLine("Spare Part name: " + spareName);
        }
    }
}
