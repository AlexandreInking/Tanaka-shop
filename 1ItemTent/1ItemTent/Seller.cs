using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ItemTent
{
    class Seller : Person
    {
        private float total = 0;
        private Client client;

        public float Total
        {
            get => total;
            set => total = value;
        }

        public Client Client
        {
            get => client;
            set => client = value;
        }

        public float MakeOffer(float price)
        {
            return 9 * price / 16;
        }

        public Seller(string name, Mastery mastery, float total, Client client) : base(name, mastery)
        {
            Total = total;
            Client = client;
        }
    }
}
