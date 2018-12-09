﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9.Units
{
    class Unit
    {
        protected int x;
        protected int y;
        protected string name;

        public Unit(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{name} is at {x}x{y}");
        }
    }
}
