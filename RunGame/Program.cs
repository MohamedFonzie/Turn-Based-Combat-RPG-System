using Domain;

namespace RunGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateWarriorCharacter();
            Console.WriteLine("\n");
            CreateRangerCharacter();
        }

        public static void CreateWarriorCharacter()
        {
            var Warrior = Archetype.Warrior;
            var character = new Character(Warrior, "Thor");

            Console.WriteLine($"Character: {character.Name}");
            Console.WriteLine($"Archetype: {Warrior.Name}");
            Console.WriteLine($"Total Damage: {character.TotalDamage}");
            Console.WriteLine($"Max HP: {character.MaxHP}");
        }
        public static void CreateRangerCharacter()
        {
            var Ranger = Archetype.Ranger;
            var character2 = new Character(Ranger, "Robin");

            Console.WriteLine($"Character: {character2.Name}");
            Console.WriteLine($"Archetype: {Ranger.Name}");
            Console.WriteLine($"Total Damage: {character2.TotalDamage}");
            Console.WriteLine($"Max HP: {character2.MaxHP}");
        }
    }
}
