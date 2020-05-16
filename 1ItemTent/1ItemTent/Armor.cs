using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ItemTent
{
    class Armor : Item
    {
        private string resisType;
        public string ResistanceType
        {
            get => resisType;
            set => resisType = value;
        }

        public Armor(int id, string name, float buyCost, string resisType) : base(id, name, buyCost)
        {
            ResistanceType = resisType;
        }

        public void ResistDamage()
        {
            Console.WriteLine("Attack resisted.");
        }
    }
}
