using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week3.Inventory
{
    internal class RangeWeapon : Weapon
    {
        protected Projectile projectile;

        public RangeWeapon(string name, float price, float damage, float attackSpeed, Projectile projectile) : base(name, price, damage, attackSpeed)
        {
            this.projectile = projectile;
        } 

        public override float GetDamagePerSecond()
        {
            return (damage + projectile.Damage) * attackSpeed;
        }
    }
}
