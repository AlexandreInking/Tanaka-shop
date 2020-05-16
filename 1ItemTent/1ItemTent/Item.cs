using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ItemTent
{
    class Item
    {
        private int id;
        private string name;
        private float buyCost;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public float BuyCost
        {
            get => buyCost;
            set => buyCost = value;
        }

        public Item(int id, string name, float buyCost)
        {
            Id = id;
            Name = name;
            BuyCost = buyCost;
        }
    }
}
