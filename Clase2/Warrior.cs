using System;
using System.Collections.Generic;
using System.Text;

namespace Clase2
{
    public class Warrior : Character
    {
        public Warrior(string name, int level, int health,int rage) : base(name, level, health)
        {            
            this.rage = rage;
        }

       private int rage;
        public int Rage
        {
            get { return rage; }            
        }
        public void SpecialAttack()
        {
            Console.WriteLine( this.name + " is performing a special attack!");
        }
        public void SpecialAttack(int hands)
        {
            Console.WriteLine(this.name + " is performing a special attack with " + hands + " hands!");
        }

        public override void Attack()
        {
            Console.WriteLine(this.name + " is swinging a sword!");
        }
    }
}
