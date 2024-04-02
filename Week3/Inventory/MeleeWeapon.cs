using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week3.Inventory
{
    internal class MeleeWeapon : Weapon
    {
        public MeleeWeapon(string name, float price, float damage, float attackSpeed) : base(name, price, damage, attackSpeed)
        {
        }

    }
}
