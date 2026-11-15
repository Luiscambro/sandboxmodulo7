using System;

namespace Clase2
{
    // HERENCIA:
    // Archer hereda de Character. Esto significa que el arquero
    // también tiene nombre, nivel, salud y los métodos de la clase padre.
    public class Archer : Character
    {
        // Creamos el constructor que recibe el nombre, nivel, salud
        // y la cantidad inicial de flechas del arquero.
        public Archer(string name, int level, int health, int arrows)

            // Utilizamos base para enviar el nombre, nivel y salud
            // al constructor de la clase padre Character.
            : base(name, level, health)
        {
            // Guardamos la cantidad inicial de flechas del arquero.
            Arrows = arrows;
        }

        // ENCAPSULAMIENTO:

        // Utilizamos una propiedad para consultar la cantidad de flechas.
        // get permite consultar su valor y private set permite modificarlo
        // únicamente desde la clase Archer.
        public int Arrows { get; private set; }

        // Creamos un método llamado ShootArrow para que el arquero
        // pueda disparar sus flechas.
        public void ShootArrow()
        {
            // Comprobamos si el arquero tiene más de cero flechas.
            if (Arrows > 0)
            {
                // Si tiene flechas, restamos una de la cantidad disponible.
                Arrows--;

                // Mostramos en pantalla que el arquero dispara una flecha.
                Console.WriteLine(name + " dispara una flecha!");
            }

            // Si no tiene flechas disponibles, ejecutamos esta condición.
            else
            {
                // Mostramos un mensaje indicando que el arquero
                // no tiene flechas para disparar.
                Console.WriteLine(name + " no tiene flechas.");
            }
        }

        // POLIMORFISMO:
        // Utilizamos override para modificar el comportamiento
        // del método Attack() que heredamos de la clase Character.
        public override void Attack()
        {
            // Cuando el arquero ataca, ejecutamos ShootArrow()
            // para que dispare una flecha.
            ShootArrow();
        }
    }
}