using System;
using Clase2;


//Character character = new Warrior("Aragorn", 10, 100, 50);

//character.name = "Juan";

//Console.WriteLine("Character Name: " + character.name);
//Console.WriteLine("Character Level: " + character.Level);
//Console.WriteLine("Character Health: " + character.Health);
//Console.WriteLine("Character has been attacked!" + character.ReceiveDamage(30) );
//character.Attack();
//(character as Warrior).SpecialAttack();

//character.level = 5;
//character.health = 100;

//character.health -= 20; // Reduce health by 20


// Creamos una lista de Character,de la clase padre.
// Una lista del tipo padre puede almacenar objetos: Warrior, Wizard y Archer
// porque esas clases se heredan de Character.
List<Character> characters = new List<Character>();

// Creamos una lista llamada characters para guardar nuestros personajes.

// Agregamos tres personajes a la lista:
// Aragorn es un guerrero de nivel 10, con 100 de salud y 50 de energía.
characters.Add(new Warrior("Aragorn", 10, 100, 50));

// Gandalf es un mago de nivel 20, con 80 de salud y 200 de maná.
characters.Add(new Wizard("Gandalf", 20, 80, 200));

// Legolas es un arquero de nivel 15, con 90 de salud y 3 flechas.
characters.Add(new Archer("Legolas", 15, 90, 3));

// Utilizamos foreach para recorrer todos los personajes de la lista.
foreach (Character character in characters)
{
    // Mostramos el nombre, el nivel y la salud del personaje.
    Console.WriteLine("Character Name: " + character.name);
    Console.WriteLine("Character Level: " + character.Level);
    Console.WriteLine("Character Health: " + character.Health);

    // Aplicamos 30 puntos de daño al personaje y mostramos el resultado.
    Console.WriteLine("Character has been attacked! " + character.ReceiveDamage(30));

    // POLIMORFISMO:
    // Ejecutamos Attack() y cada personaje realiza un ataque diferente
    // dependiendo de su clase: el guerrero golpea, el mago usa magia
    // y el arquero dispara una flecha.
    character.Attack();

    // Comprobamos si el personaje actual es un guerrero.
    if (character is Warrior guerrero)
    {
        // Ejecutamos el ataque especial del guerrero.
        guerrero.SpecialAttack();

        // Ejecutamos otra versión del ataque especial enviando el valor 2.
        guerrero.SpecialAttack(2);

        // Mostramos la cantidad de furia o energía del guerrero.
        Console.WriteLine("Warrior Rage: " + guerrero.Rage);
    }

    // Si no es un guerrero, comprobamos si es un mago.
    else if (character is Wizard wizard)
    {
        // Ejecutamos el hechizo del mago.
        wizard.CastSpell();

        // Ejecutamos otra versión del hechizo enviando el valor 20.
        wizard.CastSpell(20);

        // Mostramos la cantidad de maná disponible del mago.
        Console.WriteLine("Wizard Mana: " + wizard.Mana);
    }

    // Si no es un mago, comprobamos si es un arquero.
    else if (character is Archer archer)
    {
        // Ejecutamos el método ShootArrow() para disparar una flecha.
        archer.ShootArrow();

        // Mostramos la cantidad de flechas que tiene disponibles.
        Console.WriteLine("Archer Arrows: " + archer.Arrows);
    }

    // Dejamos una línea en blanco para separar los resultados
    // de cada personaje en la consola.
    Console.WriteLine();
}
