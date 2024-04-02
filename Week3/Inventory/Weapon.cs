using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week3.Inventory
{
    internal class Weapon : Item
    {
        protected string name;
        protected float damage;
        protected float attackSpeed;

        public Weapon(string name, float price, float damage, float attackSpeed) : base(price)
        {
            this.name = name;
            this.damage = damage;
            this.attackSpeed = attackSpeed;
        }

        public virtual float GetDamagePerSecond()
        {
            return damage * attackSpeed;
        }

        public string GetData()
        {
            return $"{name} tiene {GetDamagePerSecond()} de daño por segundo y tiene un precio de {price}";
        }
    }
}
