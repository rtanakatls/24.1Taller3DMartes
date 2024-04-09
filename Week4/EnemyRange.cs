using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week4
{
    internal class EnemyRange : Character
    {
        private int bullets;

        public EnemyRange(string name, int life, int damage, int bullets)
        {
            this.name = name;
            this.life = life;
            this.damage = damage;
            this.bullets = bullets;
        }

        public override bool CanAttack()
        {
            return IsAlive() && bullets > 0;
        }


    }
}
