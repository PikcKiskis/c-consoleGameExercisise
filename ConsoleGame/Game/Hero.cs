using Lesson9.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Hero : Unit
    {

        public Hero(int x, int y, string name) : base(x, y, name)
        {

        }

        public int MoveRight()
        {
            return x++;
        }

        public int MoveLeft()
        {
            return x--;
        }


    }
}
