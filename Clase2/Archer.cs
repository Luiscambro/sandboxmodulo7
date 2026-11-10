using System;

namespace Clase2
{
    // HERENCIA:
    // Archer hereda de Character. Por eso un arquero también tiene nombre,
    // nivel, salud, ReceiveDamage() y Attack().
    public class Archer : Character
    {
        // El constructor recibe los datos comunes del personaje y el dato
        // específico del arquero: la cantidad inicial de flechas.
        public Archer(string name, int level, int health, int arrows)
            // base(...) llama al constructor de Character para inicializar
            // name, level y health en la clase padre.
            : base(name, level, health)
        {
            Arrows = arrows;
        }

        // ENCAPSULAMIENTO:
        // Cualquier código puede consultar la cantidad de flechas mediante get,
        // pero solamente Archer puede modificarla mediante private set.
        public int Arrows { get; private set; }

        // Este método representa una acción propia de Archer.
        public void ShootArrow()
        {

            //SI la cantidad de flechas es mayor que cero...
            if (Arrows > 0)
            {
                // Cada disparo consume una flecha.
                //Resta una flecha de la cantidad disponible.
                Arrows--;
                Console.WriteLine(name + " dispara una flecha!");
                //Muestra en pantalla el nombre del personaje seguido del mensaje «dispara una flecha».
            }
            //SI NO se cumple la condición anterior...
            else
            {
                // Esta validación evita que el arquero dispare si no tiene flechas.
                Console.WriteLine(name + " no tiene flechas.");
                //Muestra en pantalla que el personaje no tiene flechas.
            }
        }

        // POLIMORFISMO:
        // Character tiene un método Attack(), pero Archer lo redefine para
        // que atacar signifique disparar una flecha.
        public override void Attack()
        {
            ShootArrow();
        }
    }
}
