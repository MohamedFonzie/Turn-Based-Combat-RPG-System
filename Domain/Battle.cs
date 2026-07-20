namespace Domain
{
    public class Battle
    {
        private Character player;
        private Character enemy;

        public Battle(Character character1, Character character2)
        {
            player = character1;
            enemy = character2;
        }

        public void StartBattle()
        {
            var turns = 1;

            while (true)
            {
                enemy.TakeDamage(player.TotalDamage);
                Console.WriteLine($"{player.Name} attacks {enemy.Name} for {player.TotalDamage} damage. {enemy.Name}'s HP is now {enemy.CurrentHP}");

                if (enemy.CurrentHP == 0)
                {
                    Console.WriteLine($"{enemy.Name} has been defeated!");
                    player.RestoreFullHP();
                    enemy.RestoreFullHP();
                    break;
                }

                player.TakeDamage(enemy.TotalDamage);
                Console.WriteLine($"{enemy.Name} attacks {player.Name} for {enemy.TotalDamage} damage. {player.Name}'s HP is now {player.CurrentHP}");

                if (player.CurrentHP == 0)
                {
                    Console.WriteLine($"{player.Name} has been defeated!");
                    player.RestoreFullHP();
                    enemy.RestoreFullHP();
                    break;
                }
                turns++;
            }
            Console.WriteLine($"Total turns: {turns}");
        }
    }
}

