using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week3.Inventory
{
    internal class Sword : MeleeWeapon
    {
        public Sword(string name, float price, float damage, float attackSpeed) : base(name, price, damage, attackSpeed)
        {

        }
    }
}
