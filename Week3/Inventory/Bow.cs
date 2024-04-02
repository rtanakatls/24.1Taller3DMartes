using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week3.Inventory
{
    internal class Bow : RangeWeapon
    {
        public Bow(string name, float price, float damage, float attackSpeed, Arrow arrow) : base(name, price, damage, attackSpeed, arrow)
        {
        }
    }
}
