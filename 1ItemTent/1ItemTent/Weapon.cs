using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ItemTent
{
    class Weapon : Item
    {
        private int masteryRestriction;
        private string dmgType;

        public string DamageType
        {
            get => dmgType;
            set => dmgType = value;
        }

        public int MasteryRestriction
        {
            get => masteryRestriction;
            set => masteryRestriction = value;
        }

        public Weapon(int id, string name, float buyCost, string dmgType, int masteryRestriction) : base(id, name, buyCost)
        {
            MasteryRestriction = masteryRestriction;
            DamageType = dmgType;
        }

        public void Attack()
        {
            Console.WriteLine("Attack complete. Damage caused 7 HP, because you aren't happy and she doesn't love you.");
        }
    }
}
