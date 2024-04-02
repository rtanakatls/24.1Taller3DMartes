using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week3.Inventory
{
    internal class Pistol : RangeWeapon
    {
        public Pistol(string name, float price, float damage, float attackSpeed, Bullet bullet) : base(name, price, damage, attackSpeed, bullet)
        {
        }
    }
}
