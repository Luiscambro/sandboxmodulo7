using System;

namespace Clase2
{
    internal class Monge : Character
    {
        public Monge(string name, int level, int health, int mana) : base(name, level, health)
        {
            this.mana = mana;
        }

        private int mana;

        public int Mana
        {
            get { return mana; }
        }

        public void SummonGolem()
        {
            Console.WriteLine(this.name + " invoco un golem!");
        }

        public void SummonGolem(int manaCost)
        {
            switch (manaCost)
            {
                case 10:
                    Console.WriteLine(this.name + " invoco un golem de piedra!");
                    break;

                case 20:
                    Console.WriteLine(this.name + " invoco un golem de fuego!");
                    break;

                default:
                    Console.WriteLine(this.name + " invoco un golem generico!");
                    break;
            }
        }

        public override void Attack()
        {
            Console.WriteLine(this.name + " invoco un golem!");
        }
    }
}