using Domain;

namespace RunGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Warrior (Low dmg, Hight HP)\n2. Ranger (High dmg, Low HP)\nChoose your class: ");
            var ClassSelection = Convert.ToInt32(Console.ReadLine());

            var player = CreateWarriorCharacter(ClassSelection);
            Console.WriteLine("\n");

            var enemy = CreateRangerCharacter();
            Console.WriteLine("\n");

            var battle = new Battle(player, enemy);
            battle.StartBattle();
        }

        public static Character CreateWarriorCharacter(int ClassSelection)
        {
            switch (ClassSelection)
            {
                case 1:
                    var warrior = Archetype.Warrior;
                    var character = new Character(warrior, "Thor");
                    Console.WriteLine($"Character: {character.Name}");
                    Console.WriteLine($"Archetype: {warrior.Name}");
                    Console.WriteLine($"Total Damage: {character.TotalDamage}");
                    Console.WriteLine($"Max HP: {character.MaxHP}");
                    return character;
                case 2:
                    var ranger = Archetype.Ranger;
                    var character2 = new Character(ranger, "Robin");
                    Console.WriteLine($"Character: {character2.Name}");
                    Console.WriteLine($"Archetype: {ranger.Name}");
                    Console.WriteLine($"Total Damage: {character2.TotalDamage}");
                    Console.WriteLine($"Max HP: {character2.MaxHP}");
                    return character2;
                default:
                    throw new ArgumentException("Invalid class selection. Please choose 1 for Warrior or 2 for Ranger.");
            }
        }

        public static Character CreateRangerCharacter()
        {
            var enemy = Archetype.Enemy;
            var character = new Character(enemy, "Dragon");

            Console.WriteLine($"Character: {character.Name}");
            Console.WriteLine($"Archetype: {enemy.Name}");
            Console.WriteLine($"Total Damage: {character.TotalDamage}");
            Console.WriteLine($"Max HP: {character.MaxHP}");

            return character;
        }
    }
}
