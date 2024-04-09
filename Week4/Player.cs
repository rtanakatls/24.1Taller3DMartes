using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week4
{
    internal class Player : Character
    {
        public Player(string name, int life, int damage)
        {
            this.name = name;
            this.life = life;
            this.damage = damage;
        }

    }
}
