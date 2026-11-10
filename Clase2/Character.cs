using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;

namespace Clase2
{
    // CLASE ABSTRACTA:
    // Creamos Character como clase principal o padre.
    // Esta clase contiene las características comunes de los personajes.
    public abstract class Character
    {
        // Creamos una propiedad para guardar y consultar el nombre del personaje.
        public string name { get; set; }

        // Declaramos dos variables privadas para guardar el nivel y la salud.
        private int level;
        private int health;

        // Creamos una propiedad que permite consultar el nivel del personaje.
        public int Level
        {
            get { return level; }
        }

        // Creamos una propiedad que permite consultar la salud del personaje.
        public int Health
        {
            get { return health; }
        }

        // Creamos un método para recibir daño y actualizar la salud del personaje.
        public int ReceiveDamage(int damage)
        {
            // Comprobamos que el daño recibido sea mayor que cero.
            if (damage > 0)
            {
                // Restamos el daño recibido a la salud del personaje.
                health -= damage;

                // Comprobamos que la salud no sea menor que cero.
                if (health < 0)
                    health = 0;
            }

            // Devolvemos la cantidad de salud que le queda al personaje.
            return health;
        }

        // CONSTRUCTOR:
        // Recibimos el nombre, el nivel y la salud inicial del personaje.
        public Character(string name, int level, int health)
        {
            // Guardamos los valores recibidos en las variables correspondientes.
            this.name = name;
            this.level = level;
            this.health = health;
        }

        // POLIMORFISMO:
        // Creamos un método virtual Attack() que las clases hijas
        // pueden modificar para tener su propio tipo de ataque.
        public virtual void Attack()
        {
            // Mostramos un mensaje indicando que el personaje está atacando.
            Console.WriteLine("Character is attacking!");
        }

    }
}
