using Lesson9.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Enemy : Unit
    {
        private int id;

        public Enemy(int id, int x, int y, string name) : base(x, y, name)
        {
            this.id = id;

        }

        public int MoveDown()
        {
            return y++;
        }

        public int GetId()
        {
            return id;

        }
    }
}
