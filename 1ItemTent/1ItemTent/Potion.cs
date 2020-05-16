using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ItemTent
{
    class Potion : Item
    {
        private float quantity;
        public float Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public Potion(int id, string name, float buyCost, float quantity) : base(id, name, buyCost)
        {
            this.quantity = quantity;
        }

        public void Recover()
        {
            Console.WriteLine("5 HP recovered.");
        }
    }
}
