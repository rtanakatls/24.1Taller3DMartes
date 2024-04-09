using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week4
{
    internal class Character
    {
        protected string name;
        protected int life;
        protected int damage;


        public virtual void TakeDamage(int damage)
        {
            life -= damage;
        }

        public virtual float GetDamage()
        {
            return damage;
        }

        public virtual string GetData()
        {
            return $"Name: {name} - Life: {life} - Damage: {damage}";
        }

        public virtual bool IsAlive()
        {
            return life <= 0;
        }

        public virtual bool CanAttack()
        {
            return IsAlive();
        }


    }
}
