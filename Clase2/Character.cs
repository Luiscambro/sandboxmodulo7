using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace Clase2
{
    public abstract class Character
    {
        public string name { get; set; }
        private int level;
        private int health;

        public int Level {
            get { return level; }
        }

        public int Health
        {
            get { return health; }
        }

        public int ReceiveDamage(int damage)
        {
            if (damage > 0)
            {
                health -= damage;

                if (health < 0)
                    health = 0;
            }

            return health;
        }


        public Character(string name, int level, int health)
        {
            this.name = name;
            this.level = level;
            this.health = health;
        }

        public virtual void Attack()
        {
            Console.WriteLine("Character is attacking!");
        }

    }
}
