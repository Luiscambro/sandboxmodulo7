using System;
// HERENCIA:
// Monge hereda de Character. Esto significa que el monje
namespace Clase2
{   // también tiene nombre, nivel, salud y los métodos de la clase padre.
    internal class Monge : Character
    {
        // Creamos el constructor que recibe el nombre, nivel, salud y maná
        public Monge(string name, int level, int health, int mana) : base(name, level, health)
        {
            // Guardamos el valor de maná en la variable correspondiente.
            this.mana = mana;
        }
        // ENCAPSULAMIENTO:
        // Utilizamos una propiedad para consultar la cantidad de maná.
        private int mana;
        // get permite consultar su valor desde otras clases.
        public int Mana
        {
            // únicamente desde la clase Monge.
            get { return mana; }
        }

        // Creamos un método llamado SummonGolem para que el monje
        public void SummonGolem()
        {
            // Mostramos en pantalla que el monje invoca un golem.
            Console.WriteLine(this.name + " invoco un golem!");
        }

        // Probamos la sobrecarga del método SummonGolem que recibe un coste de maná.
        public void SummonGolem(int manaCost)
        {
        // Mostramos en pantalla que el monje invoca un golem con un coste de maná.

            // Dependiendo del coste de maná, el monje invoca un golem diferente.
            switch (manaCost)
            {   // Si el coste de maná es 10, invoca un golem de piedra.
                case 10:
                    Console.WriteLine(this.name + " invoco un golem de piedra!");
                    break;
               // Si el coste de maná es 20, invoca un golem de fuego.
                case 20:
                    Console.WriteLine(this.name + " invoco un golem de fuego!");
                    break;
               // Si el coste de maná es 30, invoca un golem de hielo.
                case 30:
                    Console.WriteLine(this.name + " invoco un golem de hielo!");
                    break;
              
                default:
               // Si el coste de maná no coincide con ninguno de los casos anteriores, invoca un golem genérico.
                    Console.WriteLine(this.name + " invoco un golem generico!");
                    break;
            }
        }

        // POLIMORFISMO:
        // Utilizamos override para modificar el comportamiento
        public override void Attack()
        {
            Console.WriteLine(this.name + " invoco un golem!");
        }
    }
}