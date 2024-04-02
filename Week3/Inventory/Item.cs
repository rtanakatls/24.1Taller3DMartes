using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week3.Inventory
{
    internal class Item
    {
        protected string variable;
        protected float price;

        public Item(float price)
        {
            this.price = price;
        }
    }
}
