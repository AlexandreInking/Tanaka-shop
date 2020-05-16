using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ItemTent
{
    class Client : Person
    {
        private float money;


        public float Money
        {
            get => money;
            set => money = value;
        }

        public Client(string name, Mastery mastery, float money) : base(name, mastery)
        {
            Money = money;
        }

    }
}
