namespace Domain
{
    public class Battle
    {
        private Player _player;
        private Enemy _enemy;

        public Battle(Player player, Enemy enemy)
        {
            _player = player;
            _enemy = enemy;
        }

        public void StartBattle()
        {
            var turns = 1;

            while (true)
            {
                _enemy.TakeDamage(_player.TotalDamage);
                Console.WriteLine($"{_player.Name} attacks {_enemy.Name} for {_player.TotalDamage} damage. {_enemy.Name}'s HP is now {_enemy.CurrentHP}");

                if (_enemy.CurrentHP == 0)
                {
                    Console.WriteLine($"{_enemy.Name} has been defeated!");
                    _player.RestoreFullHP();
                    _enemy.RestoreFullHP();
                    break;
                }

                _player.TakeDamage(_enemy.TotalDamage);
                Console.WriteLine($"{_enemy.Name} attacks {_player.Name} for {_enemy.TotalDamage} damage. {_player.Name}'s HP is now {_player.CurrentHP}");

                if (_player.CurrentHP == 0)
                {
                    Console.WriteLine($"{_player.Name} has been defeated!");
                    _player.RestoreFullHP();
                    _enemy.RestoreFullHP();
                    break;
                }
                turns++;
            }
            Console.WriteLine($"Total turns: {turns}");
        }
    }
}

