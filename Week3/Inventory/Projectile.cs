using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week3.Inventory
{
    internal class Projectile : Item
    {
        protected float damage;

        public float Damage
        {
            get 
            { 
                return damage; 
            }
        }


        public Projectile(float price, float damage) : base(price)
        {
            this.damage = damage;
        }
    }
}
