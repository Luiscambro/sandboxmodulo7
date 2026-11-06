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


List<Character> characters = new List<Character>();

characters.Add(new Warrior("Aragorn", 10, 100, 50));
characters.Add(new Wizard("Gandalf", 20, 80, 200));

foreach (Character character in characters)
{
    Console.WriteLine("Character Name: " + character.name);
    Console.WriteLine("Character Level: " + character.Level);
    Console.WriteLine("Character Health: " + character.Health);
    Console.WriteLine("Character has been attacked! " + character.ReceiveDamage(30));
    character.Attack();

    if (character is Warrior guerrero)
    {
        guerrero.SpecialAttack();
        guerrero.SpecialAttack(2);
        Console.WriteLine("Warrior Rage: " + guerrero.Rage);
    }
    else if (character is Wizard wizard)
    {
        wizard.CastSpell();
        wizard.CastSpell(20);
        Console.WriteLine("Wizard Mana: " + wizard.Mana);
    }
    Console.WriteLine();
}
