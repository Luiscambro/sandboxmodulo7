using System;
using System.Collections.Generic;
using System.Text;

namespace Clase2
{
    internal class Wizard : Character
    {
        public Wizard(string name, int level, int health, int mana) : base(name, level, health)
        {
            this.mana = mana;
        }
        private int mana;
        public int Mana
        {
            get { return mana; }
        }
        public void CastSpell()
        {
            Console.WriteLine(this.name + " is casting a spell!");
        }

        public void CastSpell(int manaCost)
        {
           switch (manaCost)
            {
                case 10:
                    Console.WriteLine(this.name + " is casting a Thunder!");
                    break;
                case 20:
                    Console.WriteLine(this.name + " is casting a Lightning Bolt!");
                    break;
                default:
                    Console.WriteLine(this.name + " is casting a generic spell!");
                    break;
            }
        }

        public override void Attack()
        {
            Console.WriteLine(this.name + " is casting FireBall!");
        }
    }
}
