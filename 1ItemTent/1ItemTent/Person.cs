using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1ItemTent
{
    class Person
    {
        private string name;
        private Mastery mastery;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public Mastery Mastery
        {
            get => mastery.lvlMastery;
            set => mastery = value;
        }

        public Person(string name, Mastery mastery)
        {
            Name = name;
            this.mastery = mastery;
        }
        /*
            public Mastery Mastery
            {
                get => mastery;
                set => mastery = value;
            }
        */
        public void Store(Item item)
        {
            Console.WriteLine(item.Name + " stored.");
        }
    }

    public struct Mastery
    {
        public int lvlMastery;
        /*
        Determina el nivel de maestría en una habilidad:
            Novice - (1 - 10)
            Apprentice - (11 - 20)
            Graduate - (21 - 30)
            Master - (31 - 40)

            Novice 10 + 1 = Apprentice 1
            Apprentice 10 + 1 = Graduate 1
            Graduate 10 + 1 = Master 1
            Master 10 = MÁX
        */
        public int Novice
        {
            get => lvlMastery % 10;
            set => lvlMastery = value;
        }
        public int Apprentice
        {
            get => lvlMastery - 10;
            set => lvlMastery = value * 2;
        }
        public int Graduate
        {
            get => lvlMastery - 20;
            set => lvlMastery = value * 3;
        }
        public int Master
        {
            get => lvlMastery - 30;
            set => lvlMastery = value * 4;
        }

        public Mastery(int lvlMastery)
        {
            this.lvlMastery = lvlMastery;
        }

        public static implicit operator Mastery(int d) => new Mastery(d);
    }
}
